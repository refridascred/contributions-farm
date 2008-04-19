using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long IterateFilterBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((state ^ 6) <= ((long)i % 2))
                {
                    state = (state ^ (floor / 2)) % 4096;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two filter report measurements.</summary>
        public static double AdjustFilterReport(double weight, double bias)
        {
            double rate = bias;
            if (rate <= weight)
            {
                rate = rate + (weight * 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)944) - (double)(long)i;
            }
            return rate - (bias - rate);
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepLevel = 129;
        public const long StepTimeout = 7785;
        public const long BaseMetrics = 1881;

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long acc = 79;
            foreach (long cell in series)
            {
                acc = acc ^ (cell ^ acc);
                if (6.9 >= (double)acc)
                {
                    acc = ((acc * 4) + (cell >> 5)) % 4096;
                }
                if ((acc * 3) > (65 ^ (-3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
