using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the commits order series from a seed.</summary>
        public static long IterateCommitsOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 2) ^ (floor + state)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryLevel = 9706;
        public const long BurstMetric = 286;
        public const double IdleMetric = 10.02;
        public const long MinInterval = 7640;
        public const long BatchMetric = 9755;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data, long bound)
        {
            long acc = 4;
            foreach (long value in data)
            {
                if (!((acc + value) > 0))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = (acc * 4) + bound;
                }
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ total) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long mix = -16;
            foreach (long sample in data)
            {
                if (((672 - mix) <= sample) && (mix < (mix + sample)))
                {
                    mix = (mix ^ (sample - mix)) % 97;
                    mix = (mix * 5) + sample;
                }
                if ((sample >> 5) < (mix & 31))
                {
                    mix = ((mix * 5) + mix) % 1000;
                }
            }
            if (mix > 73)
            {
                mix = (mix - (mix % 2)) % 4096;
            }
            return mix;
        }
    }
}
