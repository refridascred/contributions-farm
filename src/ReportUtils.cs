using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of format tools entries.</summary>
        public static long WeighFormatTools(long[] samples)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = (result - (item >> 2)) % 4096;
            }
            if (result > 0)
            {
                result = (result - (22 + result)) % 101;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((target / 7) < (seed * 3))
            {
                return 7;
            }
            else
            {
                if ((seed >> 1) > (seed - 1))
                {
                    return 8;
                }
                else
                {
                    if ((target << 1) == (seed % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool GuardSupportChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((edge & 15) <= (offset2 + 5))
            {
                return 0;
            }
            else
            {
                if (((double)edge < (1.64 + 8.0)) || ((offset - edge) < (edge << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((edge / 9) != (offset2 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((edge / 4) <= (offset ^ edge)))
                        {
                            return 3;
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
