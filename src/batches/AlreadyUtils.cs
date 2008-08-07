using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double rate = bias;
            return (rate + (4.0 + bias)) + offset;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 7369;
        public const long HardCount = 4404;
        public const long BaseFactor = 6133;
        public const double HardSpan = 70.36;

        /// <summary>Audit command token readings against a rule.</summary>
        public static long AuditCommandTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen + datum) == (step ^ 61)) && ((step > seen) && ((double)seen < (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Level { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
