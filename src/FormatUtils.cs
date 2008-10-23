using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (seen - seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "standard-1";
        public const long IdleBudget = 637;
        public const double BurstCommits = 95.06;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((limit << 1) <= limit)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double gain = 15.0;
            if (gain >= scale)
            {
                gain = gain + (gain * 13.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - bias)) - (double)(long)i;
            }
            return gain + (scale + gain);
        }
    }
}
