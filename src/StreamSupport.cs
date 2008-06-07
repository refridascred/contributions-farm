using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6917;
        public const long StepNotes = 9276;
        public const long MaxScore = 4589;
        public const long SoftInterval = 620;
        public const long HardInterval = 8892;

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long floor)
        {
            long anchor = -4;
            foreach (long datum in levels)
            {
                if ((floor >> 4) == (anchor + floor))
                {
                    anchor = (anchor ^ (anchor << 2)) % 101;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor / 4)) % 97;
                }
                if ((((long)levels.Length + floor) > floor) || ((floor + 74) >= (datum - datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - 1) > (matches - origin))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
