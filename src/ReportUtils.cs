using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "strict";
        public const string CacheSpan = "local-1";
        public const string IdleGithubfarm = "cached-1";
        public const long BurstGithubfarm = 3258;
        public const long HardGithubfarm = 6562;

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
