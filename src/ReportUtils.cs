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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double scale = span - (double)5;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(long)i) - bias;
            }
            return scale + scale;
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
