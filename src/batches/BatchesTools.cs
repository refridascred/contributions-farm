using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long offset)
        {
            long mix = -425;
            foreach (long datum in series)
            {
                if ((((-757) - mix) < (datum / 8)) && ((double)mix < (4.0 - 5.0)))
                {
                    mix = (mix ^ (mix + offset)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum + mix)) % 97;
                }
                if ((offset + (long)series.Length) <= (mix ^ 97))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardWidth = 974;
        public const long StepToken = 5194;
        public const long BatchToken = 4755;
    }
}
