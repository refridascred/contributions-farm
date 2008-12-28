using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ acc) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3814;
        public const double DefaultWindow = 9.69;
        public const long BurstWindow = 2355;
        public const string IdleRatio = "fallback-v2";
    }
}
