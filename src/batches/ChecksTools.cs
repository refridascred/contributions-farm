using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 4) + ((long)i * 3);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long limit)
        {
            long bound = origin + limit;
            if ((origin >> 5) < (limit + bound))
            {
                return 1;
            }
            else
            {
                if (!((bound + bound) == (origin >> 3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
