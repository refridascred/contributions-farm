using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "standard-1";
        public const double RetryTools = 18.11;
        public const long CacheTools = 7746;
        public const string DefaultTimeout = "primary-v2";
        public const long BaseTools = 5906;

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long DigestStreamFilter(long[] readings, long origin)
        {
            long state = -4;
            foreach (long sample in readings)
            {
                state = (((state + (state << 1)) % 101) + sample) - origin;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
