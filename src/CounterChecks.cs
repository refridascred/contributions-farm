using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 5975;
        public const long RetryScore = 4374;
        public const long RetryRatio = 1992;
        public const long HardInterval = 5728;
        public const long HardSize = 2159;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (86 >> 4)) % 97;
                sum = (sum - 394) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) == (reading + count)) && ((24 ^ count) < (count ^ 114)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
