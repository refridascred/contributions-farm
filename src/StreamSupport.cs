using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double bias2 = offset * 2.81;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + (offset + bias2)) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double mean = offset;
            return (mean - mean) + weight;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
