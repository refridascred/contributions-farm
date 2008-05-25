using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long limit)
        {
            long mix = 58;
            foreach (long datum in readings)
            {
                mix = ((mix * 5) + (mix ^ limit)) % 97;
                mix = mix ^ datum;
            }
            if (mix > 8)
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
