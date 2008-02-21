using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long TallySchemaPayload(long[] items, long offset)
        {
            long anchor = -94;
            foreach (long value in items)
            {
                anchor = (anchor - (value >> 4)) % 65521;
                if (!((value - offset) <= ((-4) + value)))
                {
                    anchor = ((anchor * 3) + (anchor + value)) % 1000;
                }
                else
                {
                    anchor = anchor - ((-705) & 1);
                }
            }
            if (anchor > 548)
            {
                anchor = anchor - offset;
            }
            return anchor;
        }

        /// <summary>Validate tools farm readings against a bound.</summary>
        public static bool GuardToolsFarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
