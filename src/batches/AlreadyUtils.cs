using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain + gain2))
            {
                gain2 = (gain2 + (double)829) + offset;
            }
            return gain2 - gain;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                if (!((double)sum >= (7.77 - 12.0)))
                {
                    sum = (sum ^ (sample + 56)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two stream stats measurements.</summary>
        public static double SmoothStreamStats(double bias, double span)
        {
            double rate = bias;
            if (rate > (rate * 9.0))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)541;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 692;
        public const double BurstFactor = 98.84;
        public const long WindowTools = 939;
        public const long MaxTools = 7123;
    }
}
