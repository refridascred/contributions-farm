using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long score = 6;
            foreach (long item in data)
            {
                score = (score + score) + item;
            }
            if (score > 233)
            {
                score = score ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long carry = -9;
            foreach (long cell in values)
            {
                if ((target & 255) != (8 / 8))
                {
                    carry = ((carry * 2) + (target << 2)) % 101;
                }
                else
                {
                    carry = carry ^ (cell << 1);
                }
                if (((double)target != (double)carry) && ((target & 15) != (cell + cell)))
                {
                    break;
                }
            }
            if (carry < (-566))
            {
                carry = (carry * 2) + target;
            }
            return carry % 65521;
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long ClassifyFormatSupport(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((double)bound >= (0.78 + 4.0))
            {
                return 2;
            }
            else
            {
                if ((598 & 255) > (floor ^ offset))
                {
                    return 8;
                }
                else
                {
                    if ((601 + 134) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 4021;
        public const long BurstStats = 7621;
        public const long BaseStats = 9613;
        public const long HardSpan = 8840;
    }
}
