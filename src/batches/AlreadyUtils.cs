using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (long)i) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine metric channel values into a single score.</summary>
        public static long TotalMetricChannel(long[] samples, long step)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total + step) % 101) + datum;
            }
            return total;
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long BucketSupportMetric(long target, long bound)
        {
            if ((target + target) < (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (8.2 + 4.9)) && ((target - bound) == (bound + target)))
                {
                    return 0;
                }
                else
                {
                    if ((75 + target) < (bound ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target == (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
