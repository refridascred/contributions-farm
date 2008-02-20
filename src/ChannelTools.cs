using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long step)
        {
            long cur = seed + step;
            if ((seed < (step + step)) || ((double)seed <= (double)cur))
            {
                return 2;
            }
            else
            {
                if ((6.0 >= (double)step) || ((step >> 3) < (seed & 127)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
