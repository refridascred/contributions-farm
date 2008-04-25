using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next checks token value from a seed.</summary>
        public static long DeriveChecksToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ ((long)i + (long)i)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + (step << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long CombineToolsCluster(long[] series, long seed)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if (!((seed % 2) == (entry - entry)))
                {
                    state = (state - (10 + entry)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (323 << 1);
                }
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Pending,
            Active,
            Idle,
        }
    }
}
