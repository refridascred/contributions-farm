using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >= 37) || (((double)datum <= 1.2) && ((tally >> 1) > (tally + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long bound)
        {
            if (38 <= (floor + 9))
            {
                return 6;
            }
            else
            {
                if (((346 / 2) == (floor & 255)) && ((bound + 41) >= (floor / 2)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor & 255) >= (floor + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 5) > (floor & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (offset * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate / 3.0)) + (double)(long)i;
            }
            return mean + (rate + 9.0);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(seen <= (seen % 10)))
                {
                    seen = ((seen + 1) ^ reading) + bound;
                }
            }
            return seen;
        }
    }
}
