using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long CompareContributiReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Validate window report readings against a bound.</summary>
        public static bool ValidateWindowReportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 51.92;
        public const double CacheCount = 46.22;
        public const long CacheGithubfarm = 9265;
        public const double MinFactor = 6.78;
    }
}
