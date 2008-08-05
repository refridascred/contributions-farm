using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long MeasureNotesProfileOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 2) <= (matches % 16))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound <= (bound + bound)) && (542 >= acc))
                {
                    acc = ((acc << 3) ^ (bound ^ acc)) % 255;
                    acc = acc ^ (acc << 2);
                }
                else
                {
                    acc = (acc + bound) % 4096;
                }
                if (bound >= (acc + (long)i))
                {
                    acc = (acc + (acc % 12)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Ready,
            Locked,
            Draft,
        }
    }
}
