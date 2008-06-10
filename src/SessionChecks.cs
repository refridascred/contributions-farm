using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
