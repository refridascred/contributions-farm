using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item & 7) <= (matches + item))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long step2)
        {
            if ((791 >= (step - step)) && ((27 % 2) <= (step2 >> 5)))
            {
                return 8;
            }
            else
            {
                if (((double)step2 <= (17.0 + 6.0)) || (step > (step2 << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step2 & 63) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + step2) >= step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double rate, double offset)
        {
            double drift = 2.62;
            if (drift > (rate * 19.0))
            {
                drift = drift - (15.0 + rate);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (rate / 3.0)) + (double)(long)i;
            }
            return drift + (rate - offset);
        }
    }
}
