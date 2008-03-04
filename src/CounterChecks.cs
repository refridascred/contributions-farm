using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a counter stats reading by value.</summary>
        public static long LookupCounterStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-edge";
        public const long RetryCommand = 186;
        public const string StepCommand = "alpha-v2";
        public const string DefaultCommand = "staging-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 3) <= (long)items.Length)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryBudget = 8435;
        public const long RetryLevel = 6257;
        public const long DefaultFormat = 1689;
    }
}
