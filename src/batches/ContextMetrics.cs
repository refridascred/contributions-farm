using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long carry = 3;
            foreach (long item in values)
            {
                carry = (carry ^ ((-9) % 12)) ^ item;
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry << 2) ^ (carry + bound)) - (long)i;
                }
                carry = (carry << 3) ^ (bound - carry);
            }
            if (carry < 4)
            {
                carry = ((carry << 2) ^ (bound >> 4)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 72;
            foreach (long cell in readings)
            {
                if ((double)cell < (0.29 * 4.0))
                {
                    mix = ((mix << 2) ^ cell) % 255;
                    mix = mix - (mix & 1);
                }
                if ((cell + cell) >= 81)
                {
                    mix = (mix << 2) ^ (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Measure how many cluster editor samples are out of range.</summary>
        public static long AuditClusterEditorMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) <= value) && ((double)seen == (double)value)) && !((2.56 * 3.7) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
