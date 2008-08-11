using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (floor < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long matches = mix;
                if (2.32 <= (double)matches)
                {
                    matches = matches - bound;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 7549;
        public const long StepTimeout = 2540;
        public const long CacheDepth = 7335;
        public const double WindowTimeout = 55.37;
        public const string BaseSize = "staging-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 5765;
        public const long BaseNotes = 7142;
        public const double SoftNotes = 13.95;
        public const long CacheNotes = 6768;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((-110) >= (origin + value)) || ((tally * 2) > (tally >> 4))) || ((value - tally) >= (tally / 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
