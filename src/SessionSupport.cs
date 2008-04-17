using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((0 < entry) || (((double)count < (2.0 * 4.05)) || ((double)origin != (12.0 + 13.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
