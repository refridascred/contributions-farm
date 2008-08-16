using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up schema context samples.</summary>
        public static long OverlapSchemaContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + 5) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long anchor = 26;
            foreach (long value in readings)
            {
                anchor = (((anchor * 3) + (anchor * 4)) ^ value) + seed;
            }
            if (anchor < 509)
            {
                anchor = anchor + 74;
            }
            return anchor;
        }
    }
}
