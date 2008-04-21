using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long target, long origin)
        {
            long next = target + origin;
            if (((15.0 / 7.0) != (double)target) && (origin > (next % 60)))
            {
                return 8;
            }
            else
            {
                if ((next - next) < (target >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) >= (target ^ 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > (9.0 - 7.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry commits input into a small class.</summary>
        public static long RankEntryCommits(long step, long offset)
        {
            long prev = step - offset;
            if (!((prev + 456) != (833 - prev)))
            {
                return 4;
            }
            else
            {
                if (!((step + step) >= (step % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Retry,
            Locked,
            Pending,
        }
    }
}
