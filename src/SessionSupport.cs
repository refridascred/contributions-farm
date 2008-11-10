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

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (0.3 - offset))
            {
                drift = drift + drift;
            }
            return drift + (double)4;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
