using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((9.99 + 19.0) != (double)(long)i)
                {
                    mark = (mark + mark) % 4096;
                    mark = ((mark * 4) + (mark - bound)) % 4096;
                }
                if ((bound >= ((long)i - 24)) && ((mark / 2) < ((long)i << 1)))
                {
                    mark = mark - (bound << 3);
                }
                if ((double)bound <= (9.92 * 18.0))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if ((7.0 / 2.0) >= (double)score)
                {
                    score = (score + (datum + 889)) % 65521;
                }
            }
            if (score < 90)
            {
                score = (score + (score & 63)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-v2";
        public const long BatchSpan = 9713;
        public const string MaxInterval = "legacy";

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank window context input into a small class.</summary>
        public static long RankWindowContext(long floor, long step)
        {
            long next = floor ^ step;
            if (((double)next == (6.0 * 5.3)) && ((945 / 7) == (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if ((double)step != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (67 <= (6 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
