using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2057;
        public const long MaxProfile = 4190;
        public const long SoftSpan = 367;
        public const long BatchProfile = 9178;
        public const long StepProfile = 2620;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool VerifyLayoutReportRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data, long offset)
        {
            long result = 556;
            foreach (long item in data)
            {
                result = ((result * 3) + offset) % 255;
                if ((offset - result) < (offset - item))
                {
                    result = ((result << 3) ^ (item + 210)) % 1000;
                }
            }
            return result;
        }
    }
}
