using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 79.82;
        public const double SoftSpan = 43.13;
        public const double BatchDepth = 85.66;
        public const long RetryCount = 7746;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double gain = (double)(6 % 8);
            if (gain > rate)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 5.0)) + (double)(long)i;
            }
            return gain - (floor + floor);
        }

        /// <summary>Find the first checks commits entry that matches the target.</summary>
        public static long LocateChecksCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double mean = ratio / 6.0;
            return (mean - 7.0) + span;
        }
    }
}
