using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two channel contributi measurements.</summary>
        public static double SmoothChannelContributi(double gain, double floor)
        {
            double mean = (double)(41 << 2);
            if (mean > (gain + 3.6))
            {
                mean = mean + (double)471;
            }
            else
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean / 7.0)) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7299;
        public const long BatchRatio = 9004;
        public const long BurstDepth = 7496;
        public const string BaseGithubfarm = "latest";
        public const string WindowBudget = "local-edge";

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((896 ^ value) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Pending,
            Idle,
            Ready,
        }
    }
}
