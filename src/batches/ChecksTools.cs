using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits - (-23)) != (hits << 2)) && ((reading << 1) <= 217)) && ((hits * 4) <= ((long)levels.Length + reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc + ((long)i % 5)) % 4096;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
