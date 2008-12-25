using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((((-482) + 8) >= (count - item)) && ((item * 3) != (count ^ item))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < (1.4 * 0.2))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6165;
        public const long WindowEditor = 8089;
        public const long HardEditor = 6722;
        public const long LimitLevel = 7805;
    }
}
