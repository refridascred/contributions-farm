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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 55;
        public const long MinCount = 8277;
        public const long LimitReport = 3767;
        public const long MinInterval = 1148;

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
