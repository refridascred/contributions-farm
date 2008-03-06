using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long limit)
        {
            if ((9.8 - 3.85) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((2.8 + 9.22) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (10 <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer window readings.</summary>
        public static long CombineBufferWindow(long[] values)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                mark = ((mark - (long)values.Length) % 255) + sample;
            }
            return mark;
        }

        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool ValidateMetricsGraphLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
