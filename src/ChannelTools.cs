using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double ratio2 = (8.8 + floor) - ratio;
            if (ratio2 > (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long span = floor ^ bound;
            if (((span + span) > (span + floor)) && ((bound * 3) <= (floor ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((span % 60) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((31 & 1) == (floor - span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
