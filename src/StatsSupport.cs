using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Derive the next farm window value from a seed.</summary>
        public static long RollFarmWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((total * 2) > (seed << 1)))
                {
                    long delta = seed + (total - total);
                    total = ((total << 3) ^ delta) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) != (seen & 127)) && (16.0 <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) >= tally)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Synced,
            Ready,
            Draft,
            Failed,
        }
    }
}
