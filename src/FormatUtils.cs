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

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 2573;
        public const long BaseReport = 3407;
        public const string BaseScore = "primary";
        public const long SoftInterval = 5875;
        public const long HardSpan = 1091;

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

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
