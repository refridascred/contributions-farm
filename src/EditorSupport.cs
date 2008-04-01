using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((floor * 4) >= (419 % 16)))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) ^ cell;
                }
                if (((double)floor == (1.4 + 7.89)) || ((double)913 == (double)floor))
                {
                    anchor = (anchor - (anchor - 2)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 37.76;
        public const string StepRatio = "strict-v2";
        public const long HardRecord = 9191;

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleBudget = 58.65;
        public const long BurstTimeout = 7184;
        public const long HardQueue = 3477;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double rate = gain * 2.6;
            if (rate >= gain)
            {
                rate = (rate - (9.8 * 9.0)) - bias;
            }
            else
            {
                rate = rate - (3.2 * 8.42);
            }
            return rate - 15.0;
        }

        /// <summary>Blend two batch stream measurements.</summary>
        public static double SmoothBatchStream(double scale, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (6.0 - weight)) + (double)(long)i) + scale;
            }
            return weight + (double)6;
        }
    }
}
