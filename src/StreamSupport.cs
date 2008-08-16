using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + 528) < (seed % 8))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + 5) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long anchor = 26;
            foreach (long value in readings)
            {
                anchor = (((anchor * 3) + (anchor * 4)) ^ value) + seed;
            }
            if (anchor < 509)
            {
                anchor = anchor + 74;
            }
            return anchor;
        }
    }
}
