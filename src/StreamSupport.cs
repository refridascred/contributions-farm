using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if ((0.6 - 5.0) > (double)floor)
                {
                    mark = (((mark * 4) + (mark << 2)) % 97) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
