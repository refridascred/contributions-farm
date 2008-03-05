using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = (double)(72 + 897);
            if (drift >= (drift * 6.22))
            {
                drift = (drift + 13.0) - floor;
            }
            return drift + (drift + gain);
        }

        /// <summary>Combine cluster command values into a single score.</summary>
        public static long WeighClusterCommand(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                carry = (carry + (value << 3)) % 255;
                if (value < (carry - carry))
                {
                    carry = (carry * 4) + (394 * 3);
                }
                else
                {
                    carry = carry + (value + value);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series)
        {
            long carry = 494;
            foreach (long sample in series)
            {
                if ((415 - sample) >= (carry & 255))
                {
                    carry = (carry - (carry >> 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }
    }
}
