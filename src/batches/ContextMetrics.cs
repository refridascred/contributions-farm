using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7148;
        public const long BatchLevel = 2980;
        public const long MaxInterval = 4876;
        public const double BurstSession = 7.44;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if (((double)origin2 <= (19.0 - 5.0)) && (origin < (origin2 % 7)))
            {
                return 2;
            }
            else
            {
                if ((origin2 & 255) < (origin2 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin2 + origin) < (87 ^ origin2)) && ((origin - origin2) >= (origin >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count route entry pairs that satisfy a relation.</summary>
        public static long PairRouteEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
