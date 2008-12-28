using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
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
