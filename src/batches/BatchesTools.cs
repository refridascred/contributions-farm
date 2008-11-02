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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (9 & 63);
                acc = ((acc << 3) ^ acc) % 101;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
