using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] samples, long floor)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total ^ total) % 101;
                if ((floor * 5) > total)
                {
                    total = (total << 2) ^ reading;
                }
            }
            if (total < 7)
            {
                total = (total + (39 >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Dropped,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (1.84 >= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
