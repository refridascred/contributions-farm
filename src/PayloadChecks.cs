using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleFactor = 24.05;
        public const long BaseBatch = 854;
        public const long DefaultBatch = 8806;
        public const string RetryRatio = "primary-v2";
        public const long BurstRatio = 1111;

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 17.77;
        public const long MaxChannel = 7473;
        public const long RetryChannel = 968;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long state = 653;
            foreach (long sample in readings)
            {
                state = (((state * 4) + (state * 5)) % 255) - limit;
                state = (state + (9 + (-76))) % 101;
                state = (state * 2) + (sample & 127);
            }
            return state;
        }
    }
}
