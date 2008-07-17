using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i > (7.0 - 9.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((seed >> 2) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Derive the next entry metrics value from a seed.</summary>
        public static long RollEntryMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (step < (mark * 5))
                {
                    mark = ((mark * 4) + ((long)i + mark)) % 4096;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
