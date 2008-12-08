using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long CombineSessionCluster(long[] series, long origin)
        {
            long mix = -102;
            foreach (long reading in series)
            {
                if (((3.12 + 2.7) < (double)mix) || ((origin / 8) > reading))
                {
                    mix = (mix * 4) + (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 9) > (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
            Synced,
            Stale,
        }
    }
}
