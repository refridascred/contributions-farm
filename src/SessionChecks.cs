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

        /// <summary>Combine metric checks values into a single score.</summary>
        public static long CombineMetricChecks(long[] samples, long bound)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if (!((bound >> 2) <= bound))
                {
                    mark = (((mark << 3) ^ mark) % 4096) ^ item;
                }
            }
            return mark;
        }
    }
}
