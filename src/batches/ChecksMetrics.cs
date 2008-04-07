using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] values, long origin)
        {
            long acc = 7;
            foreach (long entry in values)
            {
                acc = (acc - origin) % 97;
                if ((origin + entry) > (35 * 5))
                {
                    acc = (acc ^ (acc + 54)) % 255;
                }
                if (((double)origin == (8.0 * 9.0)) && ((acc - (long)values.Length) != (origin * 5)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - origin) % 255;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5648;
        public const string RetryCommits = "local-edge";
        public const long DefaultRatio = 7070;
        public const long RetryScore = 126;
        public const double BurstSize = 41.65;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (offset / 8.0) * 11.0;
            if (drift > drift)
            {
                drift = (drift - (drift - 7.5)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)(-4);
        }
    }
}
