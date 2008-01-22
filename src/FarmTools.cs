using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data)
        {
            long mix = 519;
            foreach (long value in data)
            {
                if (!((double)mix <= (double)618))
                {
                    mix = ((mix * 5) + (mix % 10)) % 1000;
                }
                if ((value / 5) == (2 << 3))
                {
                    mix = (mix * 4) + (38 + 548);
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long origin)
        {
            long gap = floor + origin;
            if ((gap << 3) <= (floor << 1))
            {
                return 0;
            }
            else
            {
                if (gap < (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((7.2 - 9.2) > (double)gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + (-234)) >= floor)
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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - floor) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
