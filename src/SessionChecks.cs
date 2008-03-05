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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (anchor ^ 23);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
