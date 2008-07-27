using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1577;
        public const long SoftCluster = 4294;
        public const string CacheDepth = "standard-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 2611;
        public const double BurstCommand = 92.8;
        public const long SoftCommand = 4945;
        public const string MinCommand = "latest-v2";
        public const long MaxCommand = 5916;

        /// <summary>Validate notes graph readings against a bound.</summary>
        public static bool ValidateNotesGraphRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double gain = (double)0 * 6.7;
            if (gain > (double)486)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
