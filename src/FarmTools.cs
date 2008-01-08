using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
