using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long CountReportWindowHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (11 >= ((-366) + bound))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long SeriesEditorFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + step) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
