using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((514 + seen) > (entry * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches / 8) != (matches * 3))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
