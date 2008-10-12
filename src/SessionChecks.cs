using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Fold a list of graph token readings.</summary>
        public static long WeighGraphToken(long[] levels, long target)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                long delta = (target / 3) - (9 & 3);
                mark = ((mark - (delta << 2)) % 65521) ^ item;
                if ((double)target >= (double)4)
                {
                    mark = (mark * 3) + (99 ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
