using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context checks readings.</summary>
        public static long TallyContextChecks(long[] series, long target)
        {
            long state = 1;
            foreach (long cell in series)
            {
                state = (state ^ (target & 127)) % 65521;
                if ((state - target) > (state + 1))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state << 2) ^ ((long)series.Length + cell);
                }
                if (((-7) / 7) > cell)
                {
                    state = ((state << 3) ^ (target + (long)series.Length)) % 255;
                }
            }
            if (state > 610)
            {
                state = (state + target) % 1000;
            }
            return state;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if ((18.0 / 6.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound % 24) < (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Done,
            New,
            Ready,
            Active,
        }
    }
}
