using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)5 * 6.07;
            return (weight - (gain + weight)) + offset;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample > (offset + 954))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the cluster commits series from a seed.</summary>
        public static long IterateClusterCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (anchor > (long)i)
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                else
                {
                    anchor = anchor ^ (long)i;
                    anchor = (anchor ^ (long)i) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
