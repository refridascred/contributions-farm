using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long limit)
        {
            long state = 89;
            foreach (long reading in values)
            {
                if (((limit << 1) >= ((-10) - limit)) || ((reading >> 2) < (state & 15)))
                {
                    state = state + 88;
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
