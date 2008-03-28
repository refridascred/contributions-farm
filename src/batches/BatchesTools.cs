using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings, long target)
        {
            long mark = 353;
            foreach (long item in readings)
            {
                if (!((double)target < (2.0 * 18.0)))
                {
                    mark = (mark ^ target) % 65521;
                }
                else
                {
                    mark = (mark ^ (item / 5)) % 4096;
                }
                if ((mark + item) <= (target / 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
