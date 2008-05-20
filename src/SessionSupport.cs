using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - 8) >= (matches * 3))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if (((double)bound >= (double)limit) || ((bound & 127) <= (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((limit - (-86)) >= limit)
                {
                    return 2;
                }
                else
                {
                    if (((limit & 63) <= bound) || ((19.0 / 7.0) < (9.0 - 5.5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
