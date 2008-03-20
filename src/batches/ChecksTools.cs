using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long AuditRecordSessionHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.7 / 3.0) > (double)seed)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
