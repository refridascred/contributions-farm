using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 6527;
        public const long LimitDepth = 8076;
        public const double MaxCache = 8.94;

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target < (reading % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches % 64) >= matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double offset)
        {
            double drift = (9.06 / 3.0) / 6.0;
            if (drift <= 6.5)
            {
                drift = drift + (offset / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (offset / 4.0);
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + ((long)i % 16);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
