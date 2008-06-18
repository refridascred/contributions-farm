using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark - ((long)i2 - (long)i)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((9 + edge) >= (edge + edge))
            {
                return 2;
            }
            else
            {
                if (((9.0 - 10.0) != (double)bound2) || ((bound - bound2) <= edge))
                {
                    return 1;
                }
                else
                {
                    if (6.0 <= (double)edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
