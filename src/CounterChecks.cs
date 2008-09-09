using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next already commits value.</summary>
        public static double AdjustAlreadyCommits(double gain, double offset)
        {
            double weight = (double)(63 * 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - weight) - (double)(long)i) + gain;
            }
            return weight - offset;
        }

        /// <summary>Audit farm metrics readings against a rule.</summary>
        public static long TallyFarmMetricsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((346 + limit) < (619 / 4))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long RankQueueBatches(long seed, long floor)
        {
            if (!(seed <= (-13)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - seed) < (floor % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed >= (floor + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
