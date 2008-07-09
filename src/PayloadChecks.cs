using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + count) != (45 << 3)) && ((count + entry) != (9 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 88.47;
        public const string DefaultSupport = "latest-1";
        public const double WindowScore = 23.1;
        public const long MaxSpan = 2502;

        /// <summary>Roll a record graph counter forward.</summary>
        public static long SeriesRecordGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)3 <= (double)mark)
                {
                    mark = (mark * 4) + (long)i;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
