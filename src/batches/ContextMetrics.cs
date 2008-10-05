using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long offset)
        {
            if (offset <= (84 * 2))
            {
                return 4;
            }
            else
            {
                if ((37 + limit) <= (limit ^ 43))
                {
                    return 7;
                }
                else
                {
                    if ((121 / 6) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 7082;
        public const long CacheSchema = 5297;
        public const long BurstWidth = 6351;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
