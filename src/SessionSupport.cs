using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long target2)
        {
            long bound = target + target2;
            if ((bound + target2) > target)
            {
                return 3;
            }
            else
            {
                if (((double)target2 <= (double)bound) && ((double)target <= 1.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
