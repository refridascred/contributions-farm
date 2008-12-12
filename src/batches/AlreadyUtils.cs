using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 6370;
        public const long MaxLayout = 7281;
        public const string HardLayout = "alpha-1";
        public const string IdleBudget = "alpha-v2";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((offset - offset) < slot)
            {
                return 2;
            }
            else
            {
                if (((-71) + offset) >= (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot >= (7.4 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed & 255) <= offset) && ((slot % 12) == (slot / 7)))
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

        /// <summary>Validate tools order readings against a bound.</summary>
        public static bool GuardToolsOrderBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
