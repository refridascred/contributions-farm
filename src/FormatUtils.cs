using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long anchor = 22;
            foreach (long sample in values)
            {
                if ((anchor + anchor) >= (anchor / 2))
                {
                    anchor = ((anchor * 5) + (anchor - 4)) ^ sample;
                }
                anchor = anchor + anchor;
            }
            if (anchor > (-32))
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Locate a farm support reading by value.</summary>
        public static long FindFarmSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long state = 190;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (293 << 2)) % 4096;
                state = state - (state & 15);
                if ((reading + state) == (floor >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
