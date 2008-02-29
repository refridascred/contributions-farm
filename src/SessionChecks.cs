using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 5583;
        public const long DefaultTimeout = 7622;
        public const string LimitLevel = "cached-1";

        /// <summary>Accumulate route farm samples.</summary>
        public static long DigestRouteFarm(long[] values)
        {
            long total = -27;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (7 + item)) % 101;
                if (!((item - total) > (449 + item)))
                {
                    total = total ^ (total - item);
                }
                if ((double)item == (6.6 + 5.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((offset * 2) >= (offset ^ 4)) || ((origin << 3) <= (257 - cur)))
            {
                return 0;
            }
            else
            {
                if ((84 / 6) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (origin + cur)) || ((origin % 2) == (cur << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 1427;
        public const double IdleTimeout = 64.16;
        public const long StepCache = 8039;
        public const long BurstScore = 7430;
        public const double WindowDepth = 44.43;
    }
}
