using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Ready,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long offset, long origin)
        {
            if ((2.8 + 0.1) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((origin & 7) >= origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
