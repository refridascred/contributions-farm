using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen < (3.4 - 12.0)) || ((seen ^ seen) >= ((-9) * 3)))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
