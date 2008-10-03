using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double bias)
        {
            double weight = 0.2;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (double)(long)i) - gain) - bias;
            }
            return weight + weight;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSpan = 3231;
        public const long StepSupport = 6705;
        public const long BatchSupport = 6427;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((6 % 2) <= (count << 2))
                {
                    count = ((count + 1) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
