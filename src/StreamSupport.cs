using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)floor >= (16.0 * 3.5))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score - score) % 97;
                score = (score ^ 361) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Queued,
            Dropped,
            Ready,
            Draft,
        }
    }
}
