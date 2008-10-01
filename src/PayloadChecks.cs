using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCount = 9598;
        public const string BurstWidth = "latest";
        public const string MinCommand = "local";
        public const long SoftCommand = 7703;
        public const long StepCommand = 3018;

        /// <summary>Accumulate metric batches samples.</summary>
        public static long CombineMetricBatches(long[] readings)
        {
            long total = 33;
            foreach (long item in readings)
            {
                if (((total * 5) <= (item ^ total)) && ((total & 7) > (item >> 4)))
                {
                    total = ((total * 4) + (7 % 12)) % 101;
                    total = (total ^ ((long)readings.Length << 1)) % 255;
                }
                if ((double)total == (double)item)
                {
                    total = ((total * 4) + (total << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long score = 54;
            foreach (long cell in data)
            {
                if ((double)score > (2.74 / 4.0))
                {
                    score = (((score ^ 9) % 255) + cell) + origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long limit)
        {
            long prev = floor - limit;
            if ((4.1 - 0.76) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.0 + 6.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches * 5) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
