using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long floor)
        {
            long slot = step + floor;
            if ((slot + slot) < floor)
            {
                return 7;
            }
            else
            {
                if ((791 << 1) >= (slot % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step ^ step) <= 159) && ((72 >> 1) >= (step * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor order reading by value.</summary>
        public static long SeekEditorOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Draft,
            Done,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
