using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long SortCounterMetrics(long step, long limit)
        {
            long slot = step ^ limit;
            if ((limit % 8) < slot)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) == (limit >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((slot * 3) >= (slot << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if ((double)origin >= 3.71)
            {
                return 2;
            }
            else
            {
                if (origin >= 63)
                {
                    return 4;
                }
                else
                {
                    if ((origin <= seed) && ((origin >> 4) != (848 << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (712 < (seed + 622))
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

        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool GuardBufferClusterBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (22 + floor)) % 1000;
                mark = (mark << 2) ^ ((long)i % 5);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
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
