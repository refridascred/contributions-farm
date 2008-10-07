using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long origin)
        {
            long diff = offset + origin;
            if ((diff >> 5) < (offset + origin))
            {
                return 6;
            }
            else
            {
                if (origin >= (offset * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Paused,
            New,
            Done,
            Failed,
        }
    }
}
