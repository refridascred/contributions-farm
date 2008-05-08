using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long CountQueueRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 1) != (offset / 6)) || !((datum << 3) <= (offset - (long)samples.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1682;
        public const long BurstSchema = 5040;
        public const long HardTimeout = 9656;
        public const string MinRatio = "latest";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + 47) > (seen ^ entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
