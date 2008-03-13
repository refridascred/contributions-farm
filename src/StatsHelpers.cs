using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long acc = 404;
            foreach (long reading in items)
            {
                if (((double)acc > 14.0) || (((-31) + acc) > reading))
                {
                    acc = (acc + 68) % 1000;
                }
                else
                {
                    acc = (acc * 4) + bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "alpha-edge";
        public const double DefaultScore = 17.7;
        public const double LimitInterval = 7.36;
        public const string RetrySpan = "local-v2";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + (gain / 5.0)) + offset;
        }
    }
}
