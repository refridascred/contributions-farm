using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long origin)
        {
            long delta = bound + origin;
            if (6 <= (bound + delta))
            {
                return 7;
            }
            else
            {
                if (!(origin > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long offset)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (state + state)) % 101;
                if ((value % 60) >= (state - value))
                {
                    break;
                }
            }
            if (state < (-942))
            {
                state = (state * 5) + offset;
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 4) + (48 * 3);
                if (((total >> 5) != ((long)i + total)) && ((double)target != (6.0 / 8.0)))
                {
                    total = ((total * 2) + target) % 101;
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long offset)
        {
            long state = 643;
            foreach (long cell in series)
            {
                if (((cell + (-21)) >= (state % 7)) && (offset > (582 / 9)))
                {
                    state = ((state * 3) + (cell / 7)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Active,
            Done,
        }
    }
}
