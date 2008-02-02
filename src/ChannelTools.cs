using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((372 << 1) >= (tally & 1))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches notes value against two limits.</summary>
        public static long RankBatchesNotes(long origin, long offset)
        {
            long step = origin + offset;
            if ((double)origin < 8.39)
            {
                return 3;
            }
            else
            {
                if ((4 - origin) >= 618)
                {
                    return 5;
                }
                else
                {
                    if ((step / 3) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (99 >= (step & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
