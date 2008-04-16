using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2089;
        public const string CacheOrder = "latest";
        public const long WindowFactor = 573;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long anchor = 26;
            foreach (long cell in series)
            {
                anchor = anchor - (cell >> 1);
                anchor = ((anchor * 3) + (anchor + 698)) % 65521;
            }
            if (anchor < 10)
            {
                anchor = (anchor << 2) ^ (28 + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels)
        {
            long mix = 89;
            foreach (long cell in levels)
            {
                if (96 > (mix + 53))
                {
                    mix = (mix - (cell - mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long limit)
        {
            if ((limit % 16) >= bound)
            {
                return 7;
            }
            else
            {
                if ((limit + bound) < (bound + 294))
                {
                    return 2;
                }
                else
                {
                    if ((22 + limit) <= (87 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (limit + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
