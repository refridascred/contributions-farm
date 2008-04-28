using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (6 - cell)) % 1000;
            }
            if (sum < 74)
            {
                sum = ((sum * 5) + (sum * 2)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double bias2 = (bias / 3.0) - (double)15;
            if (bias2 >= bias2)
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 + (floor + bias);
            }
            return bias2 + floor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
