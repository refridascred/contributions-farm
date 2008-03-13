using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally < (388 * 5)) || (sample >= (tally >> 4))) && (tally < 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Synced,
            Pending,
            New,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
