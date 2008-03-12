using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine context account values into a single score.</summary>
        public static long ScoreContextAccount(long[] readings)
        {
            long sum = 64;
            foreach (long item in readings)
            {
                sum = (((sum * 2) + 54) % 101) ^ item;
            }
            if (sum > (-5))
            {
                sum = (sum - (61 % 100)) % 4096;
            }
            return sum;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long TallyStatsLayoutHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)seen != (7.1 - 7.2)) && (((long)readings.Length - (-469)) <= (origin & 31)))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
