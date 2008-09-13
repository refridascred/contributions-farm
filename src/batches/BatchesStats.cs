using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter metric pairs that satisfy a relation.</summary>
        public static long MatchFilterMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
