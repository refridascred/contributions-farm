using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm already value against two limits.</summary>
        public static long BucketGithubfarmAlready(long seed, long offset)
        {
            if ((seed + 48) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed + 24) == ((-207) * 5)) && ((seed << 1) != (offset & 127)))
                {
                    return 8;
                }
                else
                {
                    if ((833 - offset) == (offset - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Active,
            Stale,
            New,
            Idle,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
