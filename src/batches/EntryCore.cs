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

        /// <summary>Classify a record stream pair into a bucket.</summary>
        public static long SortRecordStream(long step, long floor)
        {
            long lane = step ^ floor;
            if ((floor >> 5) > (floor - lane))
            {
                return 2;
            }
            else
            {
                if ((floor >> 4) >= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
