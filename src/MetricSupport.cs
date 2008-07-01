using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long mix = 715;
            foreach (long value in levels)
            {
                if ((value / 3) < (value & 3))
                {
                    mix = mix - (mix * 3);
                }
                else
                {
                    mix = mix ^ (value + mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long CombineNotesContributi(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + ((-429) ^ reading)) - origin;
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
