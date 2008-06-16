using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long bound)
        {
            long total = -57;
            foreach (long entry in samples)
            {
                if (4.0 >= (double)total)
                {
                    total = (total - (bound / 3)) % 65521;
                    total = ((total * 2) + (bound + bound)) % 97;
                }
                else
                {
                    total = (total - (total + bound)) % 255;
                }
                total = ((total << 2) ^ (bound << 2)) % 4096;
                if ((total * 3) < (total + 947))
                {
                    total = ((total << 2) ^ entry) % 255;
                }
                else
                {
                    total = (total - 2) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool VerifyContextBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double gain = 1.8 * 7.98;
            if (gain <= (span - weight))
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + (weight / 2.0);
            }
            return gain - (double)(-65);
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double AdjustContributiFormat(double scale, double bias)
        {
            double gain = 6.54 * 8.38;
            if (gain < (bias - bias))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + scale;
        }
    }
}
