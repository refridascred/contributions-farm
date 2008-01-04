using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long acc = 541;
            foreach (long cell in series)
            {
                if (!(((41 - 6) >= cell) && ((cell ^ cell) < cell)))
                {
                    acc = ((acc * 5) + (acc - acc)) % 97;
                    acc = acc + (cell & 15);
                }
                if ((1.0 - 9.0) <= (double)cell)
                {
                    acc = ((acc * 5) + (acc & 63)) % 101;
                }
                else
                {
                    acc = acc ^ 482;
                }
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((matches ^ (long)samples.Length) < (entry ^ entry)) && ((double)entry >= 18.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double load = scale - 5.0;
            if (load >= (4.0 / 2.0))
            {
                load = load - (scale * 6.1);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span * 12.0)) + (double)(long)i;
            }
            return load + (scale / 5.0);
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double mean = (2.6 + bias) / 2.0;
            return (mean - (bias + bias)) + floor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double bias3 = (15.0 * 1.7) + bias;
            if (bias3 > (9.3 * 12.0))
            {
                bias3 = (bias3 + 2.02) - bias2;
            }
            else
            {
                bias3 = bias3 - (double)56;
            }
            return bias3 - (double)943;
        }
    }
}
