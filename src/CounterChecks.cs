using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long seed)
        {
            long score = 289;
            foreach (long sample in items)
            {
                if ((61 + score) < seed)
                {
                    score = (((score << 2) ^ seed) % 97) ^ sample;
                }
            }
            if (score > 752)
            {
                score = (score + seed) % 65521;
            }
            return score;
        }
    }
}
