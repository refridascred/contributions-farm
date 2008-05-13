using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first window profile entry that matches the target.</summary>
        public static long FindWindowProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data)
        {
            long score = 4;
            foreach (long value in data)
            {
                if (!((long)data.Length < (value >> 5)))
                {
                    score = (score - (8 * 5)) % 4096;
                }
            }
            return score;
        }
    }
}
