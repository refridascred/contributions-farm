using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a filter context value against two limits.</summary>
        public static long ClassifyFilterContext(long bound, long limit)
        {
            long bound2 = bound + limit;
            if ((6 & 31) == (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((bound2 % 3) != (bound << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor % 12)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
