using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (double)tally) && !((double)tally > (15.0 - 5.1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 63) != (entry * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
