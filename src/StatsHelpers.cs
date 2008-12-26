using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitLevel = 2522;
        public const long StepEntry = 8028;
        public const string RetryEntry = "alpha-v2";
        public const long BurstEntry = 5405;
        public const long StepScore = 3059;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long bound)
        {
            long slot = target + bound;
            if ((slot - slot) != (slot + target))
            {
                return 5;
            }
            else
            {
                if ((target >> 3) > 56)
                {
                    return 1;
                }
                else
                {
                    if (!((target + 75) <= (bound << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound == (3.11 + 2.0)) || ((slot + bound) > (3 - target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
