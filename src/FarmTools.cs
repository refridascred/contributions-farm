using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter route entries.</summary>
        public static long ScoreFilterRoute(long[] readings)
        {
            long sum = 799;
            foreach (long datum in readings)
            {
                if ((datum ^ sum) > (4 + sum))
                {
                    sum = ((sum * 4) + (datum * 2)) % 255;
                }
            }
            if (sum > 128)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double mean = floor;
            return (mean + mean) + scale;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long target)
        {
            if ((52 <= (step / 6)) || ((target >> 3) == (35 / 5)))
            {
                return 8;
            }
            else
            {
                if ((double)step > 3.97)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
