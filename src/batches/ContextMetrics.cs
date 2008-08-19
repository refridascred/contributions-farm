using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = carry ^ (carry & 127);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long limit)
        {
            long acc = 354;
            foreach (long entry in data)
            {
                acc = ((acc + (entry + 525)) % 65521) + limit;
                if (4 < acc)
                {
                    acc = (acc ^ (entry + acc)) % 255;
                }
                if (!(entry >= (acc % 3)))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((8.67 * 0.5) < (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
