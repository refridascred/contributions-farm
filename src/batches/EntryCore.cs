using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a context checks figure with a bias.</summary>
        public static double ProjectContextChecks(double weight, double span)
        {
            double weight2 = (double)(3 - 11);
            if (weight2 <= (weight / 3.0))
            {
                weight2 = (weight2 - weight) + span;
            }
            else
            {
                weight2 = weight2 + (weight / 7.0);
            }
            return weight2 - (weight / 2.0);
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Queued,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum * 2))
                {
                    hits = hits + 1;
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
