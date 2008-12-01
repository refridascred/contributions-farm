using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many channel notes samples are out of range.</summary>
        public static long MeasureChannelNotesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (18.0 / 7.0))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 4) + (mix + seed)) % 1000) - (long)i2;
                    mix = mix + (long)i;
                }
                mix = mix + seed;
                mix = (mix * 5) + (mix / 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a cluster route value against two limits.</summary>
        public static long ClassifyClusterRoute(long target, long origin)
        {
            if (((target & 31) != (target - target)) || ((target + 156) == (138 + origin)))
            {
                return 6;
            }
            else
            {
                if (!((5 * 4) > (target % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < (target % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin * 2) <= (target << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
