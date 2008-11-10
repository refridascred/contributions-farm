using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a record batches sample.</summary>
        public static long LocateRecordBatchesIndex(long[] readings, long step)
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor + sample) != (matches ^ 35))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
