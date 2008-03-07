using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                long delta = 28 - (state - state);
                if (!(delta <= (0 * 5)))
                {
                    state = ((state + delta) % 4096) + datum;
                    delta = delta - (state << 3);
                }
                state = state ^ 3;
            }
            if (state < 864)
            {
                state = (state * 5) + 62;
            }
            return state % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 2433;
        public const long BatchNotes = 5244;
        public const long HardNotes = 4655;
        public const string BurstInterval = "open";

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long limit)
        {
            long score = 415;
            foreach (long reading in readings)
            {
                if ((double)limit > (4.0 + 2.0))
                {
                    score = (((score * 5) + score) % 1000) ^ reading;
                }
            }
            if (score < 4)
            {
                score = score ^ limit;
            }
            return score % 4096;
        }

        /// <summary>Grade a command profile value against two limits.</summary>
        public static long GradeCommandProfile(long floor, long offset)
        {
            long cur = floor - offset;
            if ((8.33 - 4.92) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((cur + 3) == (cur / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
