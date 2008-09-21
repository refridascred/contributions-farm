using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-430) / 8) < matches)
                {
                    matches = ((matches + 2) + item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer command entry stays within the limit.</summary>
        public static bool CheckBufferCommandLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryLevel = "primary";
        public const double HardSupport = 56.26;
        public const long WindowDepth = 1876;
        public const long BatchSupport = 708;

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
