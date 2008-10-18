using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 9235;
        public const long BatchEntry = 6481;
        public const double CacheEntry = 18.44;
        public const string WindowInterval = "standard-v2";
        public const long BatchLevel = 2557;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long target)
        {
            long delta = origin ^ target;
            if ((delta << 3) != (target - target))
            {
                return 4;
            }
            else
            {
                if (!((target - target) < delta))
                {
                    return 7;
                }
                else
                {
                    if (!(7.0 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool VerifyFilterLayoutRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
