using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally + sample) >= tally) && ((tally + sample) > (sample + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                long matches = ((long)i * 2) + (mix ^ seed);
                if (mix >= (matches & 3))
                {
                    matches = ((matches * 3) + seed) % 1000;
                    mix = ((mix * 4) + (5 % 5)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
