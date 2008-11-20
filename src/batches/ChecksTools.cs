using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a support context value against two limits.</summary>
        public static long RankSupportContext(long target, long target2)
        {
            long offset = target - target2;
            if ((double)offset <= (1.8 * 6.0))
            {
                return 4;
            }
            else
            {
                if ((target << 2) <= target2)
                {
                    return 8;
                }
                else
                {
                    if ((offset - 586) < (offset ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target2 - target) >= (target2 - 9)) && ((double)target2 >= (6.1 + 3.6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry + entry) < entry) && !(4 <= (entry ^ 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 4522;
        public const long MaxNotes = 1739;
        public const long WindowCount = 7941;
        public const long BurstSpan = 1435;
        public const string DefaultInterval = "cached-edge";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
