using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 3932;
        public const string MaxWindow = "primary-v2";
        public const double SoftScore = 25.97;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((8 + tally) < (0 << 3)) && ((cell & 1) < (tally - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
