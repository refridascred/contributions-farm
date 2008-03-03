using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 3557;
        public const long BaseWindow = 2699;
        public const string RetryFactor = "local-1";
        public const string HardLevel = "open-edge";

        /// <summary>Count buffer batches pairs that satisfy a relation.</summary>
        public static long OverlapBufferBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long score = 26;
            foreach (long entry in readings)
            {
                if ((entry + score) != (entry ^ entry))
                {
                    score = score + score;
                }
            }
            if (score < 718)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
