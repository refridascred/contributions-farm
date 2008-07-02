using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            New,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if ((target * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (((target & 127) > target) || ((target + bound) >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) != (target >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches << 2) >= ((long)items.Length / 3))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
