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

        /// <summary>Fold a list of session format readings.</summary>
        public static long FoldSessionFormat(long[] readings, long limit)
        {
            long total = 6;
            foreach (long sample in readings)
            {
                if (6 <= (89 + total))
                {
                    total = (total * 3) + (limit << 1);
                }
                else
                {
                    total = (total + (0 + 34)) % 255;
                }
                if (!((limit * 4) > sample))
                {
                    break;
                }
            }
            if (total < 45)
            {
                total = (total * 5) + (total % 12);
            }
            return total;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) == (entry >> 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
