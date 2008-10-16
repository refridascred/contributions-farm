using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry & 127) <= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 53;
            foreach (long reading in readings)
            {
                score = (score - score) % 255;
                score = (score << 2) ^ reading;
            }
            return score % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
