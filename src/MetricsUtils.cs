using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) <= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Done,
            Queued,
        }
    }
}
