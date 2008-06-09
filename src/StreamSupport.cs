using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile already values into a single score.</summary>
        public static long CombineProfileAlready(long[] samples)
        {
            long total = 9;
            foreach (long value in samples)
            {
                if ((7.1 + 20.0) == (double)value)
                {
                    total = (total ^ (total ^ total)) % 65521;
                }
                else
                {
                    total = (total - (total % 16)) % 255;
                }
                if (value > total)
                {
                    break;
                }
            }
            if (total > 78)
            {
                total = ((total << 3) ^ (total / 4)) % 65521;
            }
            return total;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count notes batch pairs that satisfy a relation.</summary>
        public static long OverlapNotesBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
