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

        /// <summary>Count the route cluster entries that pass the check.</summary>
        public static long TallyRouteClusterHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((5.05 - 1.4) >= (double)datum) && ((bound / 7) != (datum + bound)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
