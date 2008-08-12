using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((8 / 6) != (hits - hits)) || ((cell >= (cell - cell)) && ((double)hits == (double)cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
