using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - 15.0) - (double)(long)i) - bias;
            }
            return weight - (double)59;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "cached-v2";
        public const long SoftDepth = 5598;
        public const long MaxLevel = 1050;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 5) <= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift * 10.0)) + (double)(long)i) + floor;
            }
            return drift + rate;
        }
    }
}
