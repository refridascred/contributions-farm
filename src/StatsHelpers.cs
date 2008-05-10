using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long AuditFormatPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((38 << 2) <= (reading + (-221)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long bound)
        {
            long state = 27;
            foreach (long item in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state + (163 + bound)) - (long)i;
                    state = state + (24 + item);
                }
                state = (state << 3) ^ (state << 1);
                if ((bound + 641) == (state - 23))
                {
                    state = (state - 93) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long step)
        {
            long next = floor + step;
            if ((6.0 + 1.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if (!((floor % 7) == (next / 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 1211;
        public const string MaxFilter = "open-1";
        public const double LimitFilter = 21.67;
        public const string LimitBudget = "open-v2";
        public const double BatchScore = 31.6;
    }
}
