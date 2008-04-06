using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long offset)
        {
            long state = 3;
            foreach (long sample in values)
            {
                if (offset > (state + state))
                {
                    state = (state << 2) ^ (sample + state);
                }
                if ((sample << 3) <= (475 + offset))
                {
                    state = state + sample;
                }
            }
            if (state > 4)
            {
                state = (state - offset) % 101;
            }
            return state % 97;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 2996;
        public const double HardCache = 78.31;
        public const string DefaultFactor = "alpha-1";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((2 - 336) >= target2)
            {
                return 4;
            }
            else
            {
                if ((double)target2 > (14.0 - 0.37))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (double)bound)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
