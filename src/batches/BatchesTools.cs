using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (mark + 38)) % 101;
                if ((double)mark <= (4.4 * 16.0))
                {
                    mark = mark ^ step;
                    mark = (mark * 4) + ((long)i << 3);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long CountBatchesCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((6.45 - 1.42) <= (double)sample) || (((double)sample <= (3.7 * 1.0)) || ((double)sample == (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
