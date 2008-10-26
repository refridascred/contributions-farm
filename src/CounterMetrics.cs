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

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long step2)
        {
            long edge = step ^ step2;
            if (edge >= (edge ^ 801))
            {
                return 8;
            }
            else
            {
                if ((-980) < (step + step2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample & 63) == (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
