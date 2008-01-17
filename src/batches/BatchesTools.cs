using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long target)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if ((((-556) << 1) <= carry) && ((1 / 8) > (target + value)))
                {
                    carry = carry + (target / 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of payload buffer entries.</summary>
        public static long TotalPayloadBuffer(long[] series, long step)
        {
            long sum = 95;
            foreach (long reading in series)
            {
                sum = sum + (sum / 3);
                if ((reading >> 4) == (78 + step))
                {
                    sum = (sum - (reading * 2)) % 97;
                }
                else
                {
                    sum = (sum - (642 / 7)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double drift = offset;
            if (drift >= (0.9 + bias))
            {
                drift = drift + drift;
            }
            return drift - offset;
        }
    }
}
