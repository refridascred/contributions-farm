using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 5.6)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 7139;
        public const long IdleSpan = 282;
        public const long CacheMetrics = 2116;
        public const double BaseMetrics = 92.17;
        public const long StepMetrics = 4141;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed << 2) < seed) && ((state & 15) <= (seed & 63)))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
