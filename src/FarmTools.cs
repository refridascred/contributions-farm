using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 + (double)7;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (2.1 / 7.0)) + (double)(long)i;
            }
            return bias2 + (double)856;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
