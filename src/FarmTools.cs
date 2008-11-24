using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((20.0 / 3.0) != (double)mark))
                {
                    mark = ((mark * 2) + (2 + mark)) % 4096;
                }
                if (mark > offset)
                {
                    mark = ((mark * 2) + (offset >> 3)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Synced,
            Failed,
        }
    }
}
