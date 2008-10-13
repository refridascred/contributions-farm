using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((hits & 1) > item) && ((hits + hits) > (bound & 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
