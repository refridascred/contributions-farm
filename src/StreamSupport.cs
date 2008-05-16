using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((35 > cell) && ((double)hits <= 9.75))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
