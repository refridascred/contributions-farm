using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a channel order reading.</summary>
        public static double BlendChannelOrder(double bias, double floor)
        {
            double scale = (floor * 9.5) + (bias * 16.0);
            if (scale > (bias - 12.0))
            {
                scale = scale - (bias * 5.69);
            }
            else
            {
                scale = scale + (double)85;
            }
            return scale + 2.9;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev + prev) >= prev)
            {
                return 3;
            }
            else
            {
                if (!((offset >> 1) < target))
                {
                    return 6;
                }
                else
                {
                    if (!(offset > (37 % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3 - offset) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 9221;
        public const string HardSchema = "open-1";
        public const long WindowSchema = 8036;
        public const long MaxWidth = 72;
        public const string BurstWidth = "standard";

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            long gap = limit - bound;
            if ((double)47 >= (double)gap)
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((gap % 5) >= (bound - gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit == (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.56 > (double)seen) || ((double)cell > (3.79 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
