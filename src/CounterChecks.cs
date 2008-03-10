using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long WeighOrderWindow(long[] values)
        {
            long anchor = 631;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + (cell << 1)) % 101;
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (6 % 100)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long step2)
        {
            if ((step2 * 2) > step)
            {
                return 6;
            }
            else
            {
                if ((step + step) <= (20 ^ step2))
                {
                    return 5;
                }
                else
                {
                    if (464 > (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= step2) || ((0.6 + 7.01) > (double)step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long WeighChecksQueue(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = ((anchor + (limit - anchor)) % 1000) ^ datum;
            }
            return anchor;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
