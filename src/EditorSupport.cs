using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 72.29;
        public const long DefaultTimeout = 7925;
        public const double BurstCount = 34.61;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long carry = 98;
            foreach (long item in readings)
            {
                if (!((565 - 7) != (item / 8)))
                {
                    carry = (carry + (item ^ (long)readings.Length)) % 97;
                }
                if ((item >> 5) > (item + 43))
                {
                    carry = carry - item;
                }
                else
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
                if (((item - item) >= (683 % 2)) || ((item % 24) > 9))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ (38 + carry)) % 65521;
            }
            return carry;
        }
    }
}
