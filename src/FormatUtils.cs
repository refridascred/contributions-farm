using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-1";
        public const double IdleSpan = 55.71;
        public const long BaseRatio = 6666;
        public const string SoftDepth = "cached-1";
        public const double IdleRatio = 58.29;

        /// <summary>Fold a list of counter entry readings.</summary>
        public static long TallyCounterEntry(long[] series)
        {
            long result = -292;
            foreach (long item in series)
            {
                if ((double)result > 8.0)
                {
                    result = result + (item % 64);
                }
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double gain = (bias * 3.17) * 7.5;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool GuardMetricFarmBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            Draft,
            Queued,
            Active,
        }
    }
}
