using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8584;
        public const double BurstDepth = 85.63;
        public const long WindowTools = 5477;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            if ((seed - seed2) >= seed2)
            {
                return 7;
            }
            else
            {
                if ((seed2 ^ seed) <= (seed2 - seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (4.06 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long step)
        {
            if ((step - 8) <= (step >> 4))
            {
                return 6;
            }
            else
            {
                if (step < (target + step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Paused,
            Done,
            Synced,
        }
    }
}
