using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long anchor = 6;
            foreach (long datum in samples)
            {
                anchor = anchor + 136;
                if ((double)datum <= 2.5)
                {
                    anchor = (anchor ^ (anchor >> 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + datum) % 97;
                }
            }
            if (anchor < 69)
            {
                anchor = anchor ^ 5;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 15.0)) + bias;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((floor % 3) < (1 ^ floor))
            {
                return 7;
            }
            else
            {
                if (((19.0 * 3.5) == (double)bound2) || ((bound >> 3) > (floor / 5)))
                {
                    return 3;
                }
                else
                {
                    if (((bound2 & 255) < (floor + bound2)) || (bound <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)82 > (15.0 - 6.0)) || ((double)floor < (3.61 - 15.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
