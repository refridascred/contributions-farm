using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mix = 665;
            foreach (long cell in samples)
            {
                mix = (mix + cell) % 101;
                if ((mix <= cell) || ((cell - cell) == (cell >> 4)))
                {
                    mix = (mix * 2) + (29 * 2);
                }
            }
            if (mix > 286)
            {
                mix = (mix - (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if ((bound & 127) != (36 & 3))
            {
                return 3;
            }
            else
            {
                if (((target * 4) <= bound) || ((double)target != (13.0 - 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (2.8 - 9.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)59 != (double)target)
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
    }
}
