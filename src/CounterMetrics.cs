using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many context order samples are out of range.</summary>
        public static long CountContextOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= 292)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi farm sample.</summary>
        public static long SeekContributiFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0 + 79) <= (seen ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
