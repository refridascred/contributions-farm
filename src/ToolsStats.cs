using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a token payload sample.</summary>
        public static long LookupTokenPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long offset)
        {
            if ((offset * 3) > (9 * 2))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) <= offset)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (303 % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((17.0 / 4.0) >= (double)bound) || ((offset + offset) <= (offset * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long floor)
        {
            long acc = 74;
            foreach (long reading in data)
            {
                if ((double)acc == (11.0 * 5.97))
                {
                    acc = ((acc - acc) % 101) - floor;
                }
                else
                {
                    acc = (acc ^ (reading >> 1)) % 97;
                }
            }
            if (acc > 91)
            {
                acc = (acc + (acc ^ acc)) % 65521;
            }
            return acc;
        }
    }
}
