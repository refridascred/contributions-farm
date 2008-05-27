using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 9209;
        public const long BurstProfile = 1876;
        public const long DefaultProfile = 7302;
        public const string WindowLevel = "legacy";

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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
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
