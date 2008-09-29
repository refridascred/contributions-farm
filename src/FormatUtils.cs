using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double bias = span;
            return (bias - span) + gain;
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
