using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double bias = 19.0 + scale;
            if (bias <= 17.0)
            {
                bias = (bias + (bias * 7.59)) - offset;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - scale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) >= (380 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema contributi samples are out of range.</summary>
        public static long TallySchemaContributiMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) < 47)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - value) <= (56 & 3))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
