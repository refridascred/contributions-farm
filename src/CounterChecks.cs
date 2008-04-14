using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long bound)
        {
            if ((double)bound > 4.4)
            {
                return 5;
            }
            else
            {
                if ((offset + bound) > (offset & 31))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 2) == (376 - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset > (double)bound) && ((double)bound != (8.1 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long limit)
        {
            long step = floor - limit;
            if (limit > (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((step + floor) >= (limit - step))
                {
                    return 6;
                }
                else
                {
                    if ((16.0 / 9.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (6.0 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
