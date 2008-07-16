using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples, long target)
        {
            long state = 11;
            foreach (long sample in samples)
            {
                if ((state + sample) == (66 + target))
                {
                    state = (state - target) % 101;
                }
                else
                {
                    state = state + (347 % 60);
                }
                state = state - (26 * 2);
                if (((17.0 / 2.0) > (double)state) || (target < sample))
                {
                    state = (state << 3) ^ target;
                }
            }
            if (state > 834)
            {
                state = (state - (2 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) < (value + floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
