using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((gap + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if ((double)gap > (5.1 - 9.22))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((bound % 7) <= (acc ^ bound)))
                {
                    acc = acc - (acc - (-291));
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
