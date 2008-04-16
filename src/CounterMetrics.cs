using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a order graph sample.</summary>
        public static long LookupOrderGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long origin)
        {
            long state = 706;
            foreach (long sample in data)
            {
                if (state < origin)
                {
                    state = state + (state + state);
                }
                if (((sample + sample) != (8 - state)) || ((double)origin != (8.5 / 6.0)))
                {
                    state = state ^ (state + sample);
                }
                else
                {
                    state = (state ^ (origin * 3)) % 1000;
                }
            }
            if (state < 22)
            {
                state = ((state << 3) ^ (origin << 1)) % 65521;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7379;
        public const double LimitReport = 2.58;
        public const long MinReport = 7522;
        public const long WindowReport = 1539;
    }
}
