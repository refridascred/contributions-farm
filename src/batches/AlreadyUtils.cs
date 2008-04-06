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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double ratio = offset - gain;
            if (ratio < 18.0)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.83 - 0.6)) + (double)(long)i;
            }
            return ratio + (3.72 / 4.0);
        }
    }
}
