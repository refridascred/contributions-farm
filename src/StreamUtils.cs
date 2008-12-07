using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) != (origin << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ 8) % 1000;
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 5) + (7 + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = (score - (score >> 1)) % 1000;
                if (((double)datum < (10.0 - 2.0)) || ((datum - datum) > (datum * 3)))
                {
                    score = (score + (435 - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Active,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1250;
        public const long MinWidth = 5494;
        public const long SoftFilter = 604;
        public const long MinFilter = 6581;
        public const double IdleFilter = 30.54;
    }
}
