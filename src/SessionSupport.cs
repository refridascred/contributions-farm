using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long RollChannelContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (offset >> 5);
                state = ((state * 4) + offset) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((step <= (step << 2)) || (count <= (17 - count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)seen > (1.4 / 9.0)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
