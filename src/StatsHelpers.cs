using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema metric readings.</summary>
        public static long TotalSchemaMetric(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if (!((entry + entry) >= (-8)))
                {
                    result = result + 714;
                }
                else
                {
                    result = ((result << 2) ^ (result << 2)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long OverlapProfileLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches stream sample.</summary>
        public static long LocateBatchesStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph schema samples.</summary>
        public static long DigestGraphSchema(long[] data, long offset)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = (total + (offset + offset)) ^ reading;
            }
            return total % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Paused,
            Stale,
            Locked,
        }
    }
}
