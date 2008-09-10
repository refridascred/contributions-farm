using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((step << 2) >= (step % 64))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 2394;
        public const long BurstTools = 6117;
        public const string MaxTools = "alpha-edge";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
