using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + result) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((matches >> 4) > (matches >> 3)) || (413 < (sample % 60))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "alpha";
        public const long MaxDepth = 2263;
        public const double IdleDepth = 41.48;
        public const long MaxCluster = 81;
        public const long DefaultCluster = 8874;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double floor)
        {
            double weight2 = 9.9;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight + weight2)) + (double)(long)i;
            }
            return weight2 - floor;
        }
    }
}
