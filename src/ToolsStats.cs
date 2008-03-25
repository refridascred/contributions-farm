using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (4 > (reading * 5))
                {
                    anchor = (anchor + (anchor / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long anchor = 78;
            foreach (long cell in items)
            {
                if ((cell - anchor) < anchor)
                {
                    anchor = (anchor - cell) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((cell / 5) == (cell + anchor))
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = ((anchor * 4) + cell) % 97;
            }
            return anchor;
        }

        /// <summary>Rank batches cache input into a small class.</summary>
        public static long SortBatchesCache(long offset, long bound)
        {
            if (!((bound + offset) <= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (5.28 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)233 < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset - bound) > offset) && ((double)bound < (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long offset, long floor)
        {
            if (((506 * 3) > (floor / 9)) && ((floor / 3) < (offset ^ 6)))
            {
                return 6;
            }
            else
            {
                if (!((offset * 2) >= (614 << 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowDepth = 41.1;
        public const long DefaultReport = 9868;
        public const long SoftReport = 8752;
    }
}
