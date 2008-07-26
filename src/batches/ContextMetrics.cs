using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + carry;
                if ((bound * 3) < (bound % 10))
                {
                    carry = (carry ^ (long)i) % 101;
                    carry = (carry + bound) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool ValidateReportEntryLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Locked,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)seed > (7.94 / 5.0))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
