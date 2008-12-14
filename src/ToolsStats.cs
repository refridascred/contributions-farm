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

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 7517;
        public const string BurstWidth = "staging-edge";
        public const double DefaultAlready = 84.94;
        public const long DefaultTimeout = 4085;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long floor)
        {
            long sum = 585;
            foreach (long item in values)
            {
                sum = (sum + ((-63) + item)) % 1000;
                if (((floor + sum) > sum) && (floor < (floor & 63)))
                {
                    sum = (sum ^ (item - floor)) % 97;
                }
                if ((item / 8) > (floor % 60))
                {
                    sum = (sum ^ (23 + item)) % 4096;
                }
            }
            return sum % 4096;
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
