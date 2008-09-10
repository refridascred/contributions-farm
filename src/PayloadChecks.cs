using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9550;
        public const string BatchTimeout = "staging-edge";
        public const string HardScore = "primary";
        public const long BaseCount = 3700;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (5 >= (reading % 24))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double rate = (double)(-368);
            if (rate > offset)
            {
                rate = (rate + (9.78 / 7.0)) + bias;
            }
            return rate - (double)48;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
