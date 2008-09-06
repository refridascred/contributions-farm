using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a editor counter sample.</summary>
        public static long FindEditorCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long MeasureFilterNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length ^ seen) != (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Locked,
            Closed,
        }
    }
}
