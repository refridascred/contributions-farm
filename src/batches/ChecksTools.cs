using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long bound)
        {
            long mix = -846;
            foreach (long item in items)
            {
                mix = ((((mix << 2) ^ (952 >> 2)) % 1000) ^ item) - bound;
                if ((double)mix > 2.8)
                {
                    break;
                }
            }
            return mix;
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
