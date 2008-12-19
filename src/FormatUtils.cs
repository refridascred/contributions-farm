using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long state = -2;
            foreach (long sample in series)
            {
                if (seed > (seed & 15))
                {
                    state = (state - (45 + (-70))) + sample;
                }
                else
                {
                    state = (state + (seed + (-37))) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((4 + state) >= reading)
                {
                    state = ((state * 4) + state) % 97;
                }
                else
                {
                    state = (state + (state * 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
