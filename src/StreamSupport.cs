using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Stale,
            Done,
            New,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long limit)
        {
            if ((floor % 64) <= (limit ^ limit))
            {
                return 1;
            }
            else
            {
                if ((15.0 + 5.92) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
