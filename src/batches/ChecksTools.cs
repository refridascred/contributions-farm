using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Ready,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long TallyClusterRecordGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((33 + reading) >= (seed % 10)) || ((seed ^ reading) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
