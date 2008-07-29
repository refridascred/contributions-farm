using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (14.0 + 13.0))
            {
                rate2 = rate2 + (double)16;
            }
            return rate2 + (rate * 16.0);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long sum = 502;
            foreach (long entry in series)
            {
                sum = (sum - (entry + entry)) - target;
            }
            if (sum < 6)
            {
                sum = (sum + (sum >> 2)) % 255;
            }
            return sum;
        }
    }
}
