using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((7.5 - 1.34) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long origin)
        {
            if (5.51 >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((step * 2) <= origin)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
