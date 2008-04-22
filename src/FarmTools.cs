using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long SortToolsContributi(long offset, long step)
        {
            long next = offset + step;
            if ((step % 10) != (step << 2))
            {
                return 3;
            }
            else
            {
                if ((step & 15) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    if (((-95) + step) > (offset / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.6 - 0.64) > (double)next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
