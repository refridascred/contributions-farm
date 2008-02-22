using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank stats already input into a small class.</summary>
        public static long GradeStatsAlready(long origin, long bound)
        {
            if (((origin / 6) != (bound - origin)) || (bound > 0))
            {
                return 8;
            }
            else
            {
                if (!((7.9 + 2.0) != (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (bound <= (origin - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound / 2) <= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long step)
        {
            if ((14.0 + 0.4) == (double)seed)
            {
                return 7;
            }
            else
            {
                if (((double)step >= (double)seed) || ((seed % 97) > (0 - step)))
                {
                    return 4;
                }
                else
                {
                    if (step >= (step & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats metrics readings.</summary>
        public static long CompareStatsMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
