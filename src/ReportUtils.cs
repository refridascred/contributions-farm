using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of account layout readings.</summary>
        public static long FoldAccountLayout(long[] readings)
        {
            long state = 42;
            foreach (long datum in readings)
            {
                if ((datum >> 3) < 47)
                {
                    state = ((state << 2) ^ datum) % 101;
                }
                else
                {
                    state = (state + (datum ^ (-810))) % 97;
                }
            }
            return state;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((bound - bound) != (offset - seed))
            {
                return 2;
            }
            else
            {
                if (((bound + bound) <= offset) && ((offset << 3) > (seed * 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
