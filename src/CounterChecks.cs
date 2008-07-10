using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (origin - result)) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long DeriveBatchesOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((total * 4) >= offset)
                {
                    total = (total << 2) ^ (offset + (long)i);
                }
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "fallback-v2";
        public const long LimitBatch = 9018;
        public const long BatchSpan = 514;
        public const long SoftFactor = 7840;

        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long CountSchemaProfileHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 5) != (tally + floor))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long CountRouteQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - hits) > (hits << 2))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
