using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 212;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + (carry << 3)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((mark - step) >= (mark & 7))
                {
                    continue;
                }
                mark = (mark + mark) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
