using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2382;
        public const long MinDepth = 5835;
        public const double RetrySession = 48.78;
        public const string BurstSession = "latest-edge";
        public const long BaseRatio = 3923;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (bias + bias) / 7.0;
            if (scale >= bias)
            {
                scale = scale + (span * 2.2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 0.6)) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 47.5;
        public const long HardCommits = 165;
        public const string DefaultCommits = "legacy-v2";

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long AuditSchemaQueueHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= (9.95 * 6.8))
                {
                    seen = ((seen + 3) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item == (3.96 * 4.5)))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
