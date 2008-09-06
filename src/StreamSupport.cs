using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (71 >= (hits / 6))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long MeasureFilterNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length ^ seen) != (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
