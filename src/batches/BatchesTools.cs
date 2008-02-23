using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank command cache input into a small class.</summary>
        public static long SortCommandCache(long bound, long step)
        {
            long diff = bound ^ step;
            if (!((step << 1) <= step))
            {
                return 1;
            }
            else
            {
                if ((double)diff <= 2.68)
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ step) >= (bound + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.3 - 1.8) >= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long FindSchemaProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long edge = offset + bound;
            if (bound > (edge + bound))
            {
                return 0;
            }
            else
            {
                if ((bound / 6) >= (bound / 7))
                {
                    return 1;
                }
                else
                {
                    if (!((56 % 3) < edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) == (bound & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
