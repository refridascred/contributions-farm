using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long offset)
        {
            if (((double)target == (double)544) && ((target + offset) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)9 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] series)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if ((double)mark != (double)4)
                {
                    mark = ((mark << 2) ^ (mark << 2)) + reading;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
