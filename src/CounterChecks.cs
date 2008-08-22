using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length >> 5) <= (hits << 3))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((-5) - entry) > (hits + offset)) && ((((-2) / 8) > (hits / 7)) && ((double)hits == (18.0 + 0.9))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long RollFormatChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((-793) * 4);
                anchor = ((anchor << 3) ^ (89 << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFactor = 5269;
        public const long MinSpan = 4023;
        public const long BatchFarm = 874;
        public const long MinFarm = 6722;
    }
}
