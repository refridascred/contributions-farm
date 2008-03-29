using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session farm counter forward.</summary>
        public static long RollSessionFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = result - (result + 435);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 3825;
        public const long WindowCount = 2509;
        public const long DefaultTools = 998;
        public const long DefaultSize = 7992;
        public const long HardTimeout = 8706;

        /// <summary>Rank report counter input into a small class.</summary>
        public static long RankReportCounter(long offset, long target)
        {
            long slot = offset ^ target;
            if (!((double)offset < (8.0 + 7.77)))
            {
                return 5;
            }
            else
            {
                if (!(offset >= (5 << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((slot + slot) >= ((-736) << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)slot != (2.0 / 5.0)) && ((offset % 12) < slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
