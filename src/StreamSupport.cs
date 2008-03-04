using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Count the layout format entries that pass the check.</summary>
        public static long MeasureLayoutFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 4) >= (81 >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
