using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the batches cluster series from a seed.</summary>
        public static long IterateBatchesCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 755;
            foreach (long entry in items)
            {
                if ((67 + (long)items.Length) != (result % 97))
                {
                    result = (result + (36 & 15)) % 4096;
                    result = (result ^ (step & 31)) % 4096;
                }
                if (step > (step + step))
                {
                    result = (result + (37 ^ result)) % 97;
                }
                if (((result / 9) == (result >> 4)) && ((entry * 2) > step))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally < (floor - floor))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
