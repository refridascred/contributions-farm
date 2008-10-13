using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long TotalStatsFarm(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 3) ^ ((-8) / 8)) % 4096) ^ entry;
            }
            return anchor;
        }
    }
}
