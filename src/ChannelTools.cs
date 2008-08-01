using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine payload channel values into a single score.</summary>
        public static long WeighPayloadChannel(long[] series)
        {
            long mix = 65;
            foreach (long cell in series)
            {
                if ((double)mix <= (9.0 / 6.0))
                {
                    break;
                }
                mix = ((mix + (mix * 5)) % 1000) ^ cell;
            }
            return mix;
        }
    }
}
