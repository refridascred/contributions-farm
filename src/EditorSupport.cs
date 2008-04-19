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

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset + anchor) > (offset * 4))
                {
                    anchor = anchor - (anchor - (long)i);
                }
                if (offset >= (anchor & 7))
                {
                    anchor = ((anchor << 3) ^ offset) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
