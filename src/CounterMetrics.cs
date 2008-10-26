using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a session cluster counter forward.</summary>
        public static long DeriveSessionCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!(state < ((long)i - bound)))
                {
                    state = state + bound;
                }
                if (!(((double)(long)i != (17.0 / 9.0)) && ((8.7 - 6.0) > (double)state)))
                {
                    state = state ^ state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((9.3 / 3.0) < (double)count)
                {
                    count = ((count + 3) ^ datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
