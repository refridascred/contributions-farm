using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Queued,
            Retry,
            Closed,
            New,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + 140) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double mean = (double)32;
            if (mean >= (double)529)
            {
                mean = (mean - bias) + floor;
            }
            return mean + 2.71;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long step)
        {
            long carry = -1;
            foreach (long item in series)
            {
                if (!((step * 2) != (step - carry)))
                {
                    carry = (((carry * 5) + (carry ^ step)) % 65521) - item;
                }
                carry = (carry << 2) ^ (step >> 2);
            }
            return carry;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (9 > value)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
