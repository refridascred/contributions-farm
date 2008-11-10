using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                if ((14.0 - 8.0) < (double)datum)
                {
                    mark = (mark * 4) + mark;
                }
                if (75 < datum)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((10.0 > (double)entry) || (step <= (matches - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardInterval = "alpha";
        public const double WindowScore = 23.73;
        public const string LimitInterval = "latest-edge";
        public const long StepRatio = 4834;
        public const long MinLevel = 9578;
    }
}
