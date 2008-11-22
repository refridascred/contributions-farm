using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + seed) % 4096;
                total = total ^ (seed >> 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long WindowSession = 7288;
        public const double DefaultSize = 54.32;

        /// <summary>Validate record context readings against a bound.</summary>
        public static bool VerifyRecordContextLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long floor2)
        {
            long offset = floor - floor2;
            if (9.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor2 >> 3) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor2) > (81 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            New,
            Stale,
            Draft,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
