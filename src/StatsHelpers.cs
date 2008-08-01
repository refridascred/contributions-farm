using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            if ((25 + offset) < step)
            {
                return 2;
            }
            else
            {
                if (step < (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if (offset > (offset << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step % 16) <= offset) && ((step % 100) > (offset << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter support readings against a rule.</summary>
        public static long MeasureFilterSupportOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 3) <= datum)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double rate = 9.0;
            if (rate > rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (8.35 + 7.64))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
