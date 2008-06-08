using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long result = 31;
            foreach (long entry in levels)
            {
                result = (((result * 5) + result) % 97) - target;
                result = (result + (entry + (long)levels.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Match up format report samples.</summary>
        public static long OverlapFormatReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item % 64) != (368 & 1)) || (matches >= (item >> 4)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
