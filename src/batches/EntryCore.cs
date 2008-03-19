using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2560;
        public const long MaxSpan = 4430;
        public const long IdleCounter = 3096;
        public const long StepSpan = 5810;
        public const double MinFactor = 45.79;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long target)
        {
            long state = 32;
            foreach (long reading in readings)
            {
                state = ((state * 5) + (reading ^ 8)) + target;
            }
            if (state < (-29))
            {
                state = ((state * 2) + (4 << 3)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first already buffer entry that matches the target.</summary>
        public static long FindAlreadyBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
