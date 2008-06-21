using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long origin, long target)
        {
            long edge = origin - target;
            if ((target + target) > target)
            {
                return 7;
            }
            else
            {
                if ((6.37 * 20.0) > (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((58 - edge) > (226 - origin)) && ((edge << 2) == (target - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge / 7) == (edge & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((575 * 5) == (reading & 31))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long FoldCommitsEditor(long[] readings, long target)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = state - (entry + state);
                state = state ^ target;
                state = state + (entry + entry);
            }
            return state % 4096;
        }
    }
}
