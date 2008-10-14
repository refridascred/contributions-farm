using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long origin)
        {
            long gap = offset + origin;
            if (612 < (offset + gap))
            {
                return 3;
            }
            else
            {
                if ((origin > (origin ^ offset)) && ((gap << 3) < gap))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 2) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap != (8.48 - 9.5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor * 4) + anchor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long total = 444;
            foreach (long value in levels)
            {
                if ((double)total <= (1.2 + 6.0))
                {
                    total = total + total;
                    total = ((total * 2) + (total ^ total)) % 4096;
                }
                if ((limit + limit) < (limit & 3))
                {
                    total = total ^ (value + (long)levels.Length);
                }
            }
            return total;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 351;
            foreach (long value in samples)
            {
                state = ((state + (8 ^ state)) % 1000) ^ value;
            }
            return state % 4096;
        }
    }
}
