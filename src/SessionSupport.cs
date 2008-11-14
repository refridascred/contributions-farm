using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches notes samples.</summary>
        public static long OverlapBatchesNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first command metrics entry that matches the target.</summary>
        public static long LookupCommandMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long acc = 458;
            foreach (long item in values)
            {
                if ((12.0 / 3.0) >= (double)item)
                {
                    acc = (acc - (acc << 1)) % 1000;
                    acc = ((acc << 3) ^ acc) % 65521;
                }
                acc = (acc * 4) + item;
                if ((3.0 - 6.46) != (double)item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
