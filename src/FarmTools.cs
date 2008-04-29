using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long limit)
        {
            long mix = 35;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.0 + 6.0))
                {
                    mix = ((mix + (537 >> 1)) % 4096) + limit;
                }
                if ((entry * 3) < mix)
                {
                    break;
                }
            }
            if (mix > 78)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.65 - 15.0) >= (double)origin)
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
