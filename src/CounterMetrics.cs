using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if ((3.3 * 1.7) < (double)score)
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score + (value + value);
                }
            }
            return score % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] readings)
        {
            long state = 773;
            foreach (long item in readings)
            {
                state = state ^ (item + state);
            }
            if (state < 72)
            {
                state = (state * 2) + (state - state);
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items, long target)
        {
            long result = 99;
            foreach (long value in items)
            {
                result = ((result * 2) + (target / 3)) ^ value;
            }
            return result;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
