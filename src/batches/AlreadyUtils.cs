using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the graph already entries that pass the check.</summary>
        public static long CountGraphAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((3.4 / 9.0) < (double)mix)
                {
                    break;
                }
                mix = mix - mix;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 3925;
        public const long MaxDepth = 820;
        public const long HardProfile = 9432;
        public const long CacheProfile = 3427;
        public const long BatchInterval = 1741;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long mark = 919;
            foreach (long datum in series)
            {
                if ((1 <= (datum * 3)) && (mark < (datum - mark)))
                {
                    mark = mark + 8;
                }
                else
                {
                    mark = (mark ^ ((long)series.Length + mark)) % 65521;
                }
            }
            return mark;
        }
    }
}
