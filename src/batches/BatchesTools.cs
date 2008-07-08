using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + (long)i) < (floor + floor))
                {
                    continue;
                }
                else
                {
                    mix = (mix << 3) ^ (floor - 962);
                }
                if (floor <= (mix + floor))
                {
                    mix = (mix ^ floor) % 255;
                    mix = (mix + floor) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit contributi metrics readings against a rule.</summary>
        public static long MeasureContributiMetricsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((-7) & 7) < tally)
                {
                    tally = ((tally + 3) - sample) + offset;
                }
            }
            return tally;
        }
    }
}
