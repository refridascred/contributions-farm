using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen >= (item - seen))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading > (bound % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) == (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long OverlapNotesBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
