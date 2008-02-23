using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long target, long seed)
        {
            if ((target > (target - target)) || (seed < (target * 5)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed != (7.7 - 6.36)))
                {
                    return 0;
                }
                else
                {
                    if (target <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((8 / 6) >= (seed / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool GuardWindowBatchesBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
