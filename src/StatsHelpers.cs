using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)origin <= (7.69 - 2.17))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = -138;
            foreach (long item in readings)
            {
                anchor = (anchor + (541 - anchor)) % 97;
                if ((anchor + item) <= (item / 3))
                {
                    anchor = (anchor ^ (item % 16)) % 65521;
                }
                else
                {
                    anchor = (anchor * 3) + item;
                }
            }
            if (anchor > (-3))
            {
                anchor = (anchor ^ ((long)readings.Length & 7)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (!((step ^ seed) >= step))
            {
                return 0;
            }
            else
            {
                if (((double)step == (double)307) || ((double)step <= (3.4 - 1.09)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - step) <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3 >= seed) && ((9.1 + 8.37) != (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support contributi measurements.</summary>
        public static double BlendSupportContributi(double scale, double span)
        {
            double rate = span - (double)649;
            return (rate - (double)1) + scale;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
