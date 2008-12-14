using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long step)
        {
            if ((89 >> 4) >= bound)
            {
                return 1;
            }
            else
            {
                if (!(150 >= (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound % 8) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + step) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 7517;
        public const string BurstWidth = "staging-edge";
        public const double DefaultAlready = 84.94;
        public const long DefaultTimeout = 4085;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 1065;
        public const long CacheCluster = 6336;
        public const double WindowCluster = 90.63;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long floor)
        {
            long sum = 585;
            foreach (long item in values)
            {
                sum = (sum + ((-63) + item)) % 1000;
                if (((floor + sum) > sum) && (floor < (floor & 63)))
                {
                    sum = (sum ^ (item - floor)) % 97;
                }
                if ((item / 8) > (floor % 60))
                {
                    sum = (sum ^ (23 + item)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double bias)
        {
            double bias2 = 2.6 * 8.3;
            if (bias2 > scale)
            {
                bias2 = (bias2 + bias2) + bias;
            }
            return bias2 + (scale - bias2);
        }
    }
}
