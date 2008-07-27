using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target >> 5) >= (target & 63))
                {
                    acc = (acc - (long)i) % 97;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetrySize = "strict";
        public const long DefaultStream = 5028;
        public const long MaxSpan = 9950;
        public const long CacheStream = 943;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (42 > bound)
            {
                return 1;
            }
            else
            {
                if (2.8 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((738 & 255) > (step >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
