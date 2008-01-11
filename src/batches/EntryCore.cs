using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 6176;
        public const string MaxSize = "local";
        public const long MinBudget = 6148;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long seed)
        {
            long diff = offset - seed;
            if (((11.0 / 2.0) >= (double)seed) && ((5.0 * 8.64) == (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset < seed) && (diff > (offset ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ 866) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
