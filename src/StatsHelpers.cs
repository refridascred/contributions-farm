using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LocateCacheClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = -398;
            foreach (long reading in samples)
            {
                acc = (((acc << 3) ^ (401 - 405)) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
