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

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleTimeout = 1592;
        public const double MinInterval = 71.73;
        public const double BaseSpan = 21.94;
        public const long StepDepth = 8057;
        public const string DefaultSize = "cached-1";

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
