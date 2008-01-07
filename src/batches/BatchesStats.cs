using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheWidth = 3118;
        public const long BaseReport = 1042;
        public const long BurstReport = 807;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer batches samples are out of range.</summary>
        public static long MeasureBufferBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > (tally / 6))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
