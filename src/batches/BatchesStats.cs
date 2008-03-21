using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = (((carry - (carry * 5)) % 101) - cell) - floor;
                if ((carry / 6) >= (91 / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double bias = (span + span) - (double)1;
            if (bias <= ratio)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (span * 0.4);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples, long target)
        {
            long total = 27;
            foreach (long entry in samples)
            {
                if (((15.0 - 5.0) != (double)entry) && (total <= (entry - target)))
                {
                    total = (total + (target % 64)) % 4096;
                    total = (total + ((-470) % 24)) % 101;
                    break;
                }
                if (((entry - entry) == (entry + target)) && ((total - entry) >= ((long)samples.Length << 2)))
                {
                    total = ((total * 5) + (target & 63)) % 255;
                }
            }
            if (total > 127)
            {
                total = (total - total) % 97;
            }
            return total;
        }
    }
}
