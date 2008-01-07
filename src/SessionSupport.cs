using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (weight * 6.0))
            {
                scale = scale + (bias - bias);
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 8.0)) + (double)(long)i;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Validate session format readings against a bound.</summary>
        public static bool ValidateSessionFormatLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
