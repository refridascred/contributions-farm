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

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long TallyEntryBatches(long[] readings)
        {
            long carry = -153;
            foreach (long value in readings)
            {
                carry = (((carry * 4) + ((-529) + carry)) % 255) ^ value;
                if ((carry ^ carry) != (carry + carry))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
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
