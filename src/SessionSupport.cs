using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long target)
        {
            long offset = floor ^ target;
            if (floor <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (!((target >> 4) >= (88 % 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long floor, long step)
        {
            long bound = floor ^ step;
            if (bound >= 9)
            {
                return 1;
            }
            else
            {
                if (2.2 <= (6.5 - 5.32))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
