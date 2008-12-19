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

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long AuditEditorMetricsHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((771 + 593) > step)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
