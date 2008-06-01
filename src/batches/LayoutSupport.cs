using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long DigestAlreadySupport(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (datum > (acc ^ 77))
                {
                    acc = ((acc << 2) ^ (datum + acc)) % 255;
                }
                else
                {
                    acc = acc - (datum >> 3);
                }
                acc = acc - (datum ^ datum);
                acc = (acc + (datum & 31)) % 101;
            }
            if (acc > 940)
            {
                acc = acc ^ (acc * 5);
            }
            return acc % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 4100;
        public const string StepCount = "standard-edge";
        public const long RetryLevel = 5848;
        public const double LimitBudget = 20.69;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double rate = bias;
            if (rate < ratio)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias - 7.24)) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
