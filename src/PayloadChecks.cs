using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the entry record entries that pass the check.</summary>
        public static long CountEntryRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double ratio, double offset)
        {
            double ratio2 = (double)((-50) / 9);
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = (ratio2 - (ratio / 5.0)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (double)109) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
