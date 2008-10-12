using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            long edge = target + target2;
            if (target <= (target2 - 753))
            {
                return 1;
            }
            else
            {
                if ((edge & 7) < 82)
                {
                    return 2;
                }
                else
                {
                    if (!((edge << 2) <= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (7.5 * 2.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long offset)
        {
            if (3.4 >= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed == (12.0 * 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) > (offset % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed ^ offset) != (offset + seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long AuditFarmSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) >= reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
