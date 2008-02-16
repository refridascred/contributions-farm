using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            if ((18.0 - 4.7) < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit * 4) <= ((-8) % 7))
                {
                    return 5;
                }
                else
                {
                    if (((offset >> 5) > (limit + limit)) && ((limit % 64) <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + 834) <= 42) || ((limit ^ limit) <= (limit / 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(target <= (long)series.Length) || (((7.1 - 8.9) <= (5.0 + 7.1)) && ((double)matches == (3.71 + 5.1))))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
