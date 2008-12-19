using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor & 63) < anchor)
                {
                    anchor = (anchor << 3) ^ (limit + (long)i);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 3) ^ (limit + anchor)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleTimeout = 28.69;
        public const long LimitEntry = 505;
        public const long MaxCount = 2097;
        public const double IdleEntry = 25.67;
    }
}
