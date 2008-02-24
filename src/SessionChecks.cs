using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.6 + 6.3) > (double)(long)samples.Length)
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token graph samples.</summary>
        public static long TotalTokenGraph(long[] series)
        {
            long mark = 577;
            foreach (long sample in series)
            {
                if (sample > (mark & 7))
                {
                    mark = (mark + (mark % 10)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (sample + 9)) % 4096;
                }
            }
            if (mark > 874)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Rank window contributi input into a small class.</summary>
        public static long GradeWindowContributi(long target, long seed)
        {
            if (((target / 5) >= (26 / 3)) || (4.8 >= (double)target))
            {
                return 7;
            }
            else
            {
                if (((double)target < (6.4 * 5.06)) && ((target * 2) > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 1) < (target - target)) || ((target << 1) == (target + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target < (3.0 + 4.06))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double bias = rate;
            if (bias < 5.49)
            {
                bias = bias - (rate - rate);
            }
            return bias - (floor - bias);
        }
    }
}
