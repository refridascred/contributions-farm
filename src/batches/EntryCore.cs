using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster route readings against a bound.</summary>
        public static bool GuardClusterRouteLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 5477;
        public const long HardSupport = 145;
        public const long StepSupport = 1440;
        public const long MaxSpan = 5534;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Locked,
            Synced,
        }
    }
}
