using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long seed)
        {
            if ((step & 3) < (74 + seed))
            {
                return 6;
            }
            else
            {
                if ((7.0 * 2.0) < (9.59 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if (((238 + seed) <= step) && (seed < (seed - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step >> 5) > (seed - seed)) && ((step * 3) >= (step / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next format stream value.</summary>
        public static double ProjectFormatStream(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - rate2) - floor;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 - rate2)) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
