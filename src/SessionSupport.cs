using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowScore = 2691;
        public const long DefaultSchema = 581;
        public const long StepInterval = 3858;
        public const long MinRatio = 5686;

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
