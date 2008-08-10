using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long bound2)
        {
            long diff = bound - bound2;
            if ((diff % 64) <= (bound2 - diff))
            {
                return 2;
            }
            else
            {
                if ((bound2 * 4) >= bound2)
                {
                    return 0;
                }
                else
                {
                    if (diff < (diff >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(1.0 >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long mark = 64;
            foreach (long value in values)
            {
                if (((-2) / 9) != (value ^ 3))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark ^ (value / 5)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample * 4) > sample) && ((double)74 > (double)sample)) || (((7.3 - 2.2) <= (double)matches) && (matches > (matches & 255))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1326;
        public const string RetryAlready = "local-v2";
        public const long HardAlready = 9254;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
