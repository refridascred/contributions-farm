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

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long mark = 512;
            foreach (long sample in readings)
            {
                mark = (((mark * 4) + mark) % 4096) ^ sample;
            }
            if (mark < 79)
            {
                mark = ((mark * 4) + (525 & 15)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2925;
        public const long WindowSpan = 7537;
        public const long SoftInterval = 9783;
        public const long HardLevel = 2686;
        public const string StepLevel = "stable";

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
