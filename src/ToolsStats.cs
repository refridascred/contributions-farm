using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < result)
                {
                    result = (result ^ 9) % 4096;
                    result = (result ^ (result * 2)) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (!(slot >= offset))
            {
                return 3;
            }
            else
            {
                if (((offset ^ offset2) > (slot << 1)) && ((1 + offset) == (offset2 & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 % 24) > 25)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long WeighChannelBatches(long[] samples)
        {
            long acc = -92;
            foreach (long item in samples)
            {
                acc = ((acc - acc) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long OverlapMetricClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
