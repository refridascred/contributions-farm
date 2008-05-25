using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long GradeAccountEditor(long offset, long limit)
        {
            long bound = offset + limit;
            if (!((offset << 2) <= bound))
            {
                return 5;
            }
            else
            {
                if (75 <= (offset % 12))
                {
                    return 8;
                }
                else
                {
                    if (((limit + 5) > (limit + bound)) && ((5 + offset) != (limit * 3)))
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

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = (double)(759 * 4);
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (weight * 3.87);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
