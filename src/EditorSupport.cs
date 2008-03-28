using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 8702;
        public const long WindowSession = 5859;
        public const string MinSession = "legacy-v2";
        public const long DefaultBudget = 3549;
        public const double LimitSession = 73.53;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if ((carry + carry) != (datum - datum))
                {
                    carry = (carry - 6) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (datum ^ (long)data.Length)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            if (bound < (bound & 127))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (7.8 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((8.5 * 7.93) <= (2.58 + 0.3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double ratio = scale * 7.18;
            if (ratio <= floor)
            {
                ratio = ratio - (double)159;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + matches) >= (matches * 3))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
