using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSize = 9955;
        public const double LimitScore = 17.25;
        public const string MinQueue = "staging";
        public const long RetryQueue = 5936;
        public const long BaseQueue = 9560;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Stale,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = 7.8;
            if (weight >= gain)
            {
                weight = (weight + (double)8) - span;
            }
            return weight + weight;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long acc = 715;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = acc ^ ((long)i ^ (long)i);
                }
                acc = ((acc << 3) ^ acc) % 97;
                if (sample > (2 % 64))
                {
                    acc = (acc ^ (43 + acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
