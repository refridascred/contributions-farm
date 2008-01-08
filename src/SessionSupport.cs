using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long offset)
        {
            long score = 126;
            foreach (long cell in readings)
            {
                score = (((score << 3) ^ (59 * 2)) - cell) - offset;
            }
            if (score > 31)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
