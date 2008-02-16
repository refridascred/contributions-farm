using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter account pairs that satisfy a relation.</summary>
        public static long CompareFilterAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((598 / 5) > (count - bound)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools format samples.</summary>
        public static long TotalToolsFormat(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((cell - acc) < acc)
                {
                    acc = (acc * 2) + cell;
                }
            }
            if (acc > 2)
            {
                acc = acc + (761 ^ 94);
            }
            return acc;
        }
    }
}
