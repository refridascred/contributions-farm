using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of editor counter readings.</summary>
        public static long OverlapEditorCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long step)
        {
            if ((seed >> 2) == (step + step))
            {
                return 6;
            }
            else
            {
                if ((7.86 + 7.02) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (12.0 * 0.32))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.57 / 2.0) != (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
            Synced,
            Dropped,
        }
    }
}
