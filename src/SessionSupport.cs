using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Combine editor report values into a single score.</summary>
        public static long FoldEditorReport(long[] levels, long target)
        {
            long result = 94;
            foreach (long entry in levels)
            {
                result = ((result + (870 + result)) % 65521) ^ entry;
                result = (result - (target ^ 43)) % 65521;
            }
            if (result < (-3))
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Rank metrics filter input into a small class.</summary>
        public static long GradeMetricsFilter(long limit, long target)
        {
            if ((target + target) < (219 & 127))
            {
                return 0;
            }
            else
            {
                if ((6.5 / 5.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((double)limit < 6.87) && ((limit + target) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
