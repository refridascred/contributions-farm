using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long target)
        {
            long gap = limit - target;
            if (9 <= (88 + target))
            {
                return 0;
            }
            else
            {
                if (!((33 ^ 756) <= (target + gap)))
                {
                    return 4;
                }
                else
                {
                    if (!(((-44) + 0) > (limit + 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target & 127) == (gap / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
