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

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long anchor = 546;
            foreach (long entry in data)
            {
                if ((anchor + entry) == (entry + anchor))
                {
                    anchor = anchor - (entry * 2);
                }
                if ((double)entry < (5.0 - 5.0))
                {
                    anchor = ((anchor * 4) + (entry & 127)) % 4096;
                }
            }
            return anchor % 65521;
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
