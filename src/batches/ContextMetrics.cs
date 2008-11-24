using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 526;
        public const long BatchSpan = 3196;
        public const long MaxDepth = 7775;
        public const long IdleDepth = 5944;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((origin & 255) == (origin + hits)) && (hits > (37 >> 1))) && !((double)hits > (0.1 - 13.0)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(3 ^ 75);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + bias) + (double)(long)i) - gain;
            }
            return rate + bias;
        }
    }
}
