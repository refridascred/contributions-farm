using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((limit + limit) == (limit >> 4))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double ratio = rate;
            if (ratio > (ratio - 4.5))
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor / 8.0)) + (double)(long)i;
            }
            return ratio + 15.0;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
