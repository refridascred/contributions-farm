using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mark = 77;
            foreach (long reading in readings)
            {
                mark = (mark - (mark + mark)) ^ reading;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Match up metric editor samples.</summary>
        public static long MatchMetricEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
