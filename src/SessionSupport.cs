using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (rate * 1.02))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + ratio;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result + ((long)i + floor)) % 97;
                result = ((result << 3) ^ floor) % 255;
                result = (result * 2) + (floor >> 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
