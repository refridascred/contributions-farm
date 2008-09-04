using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count < ((long)values.Length + count)) || ((double)entry < (1.3 + 3.67))) && ((count - 38) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long score = 452;
            foreach (long value in data)
            {
                score = (score * 2) + (value + target);
            }
            return score;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings, long offset)
        {
            long anchor = 5;
            foreach (long cell in readings)
            {
                if ((cell % 12) == (offset - cell))
                {
                    anchor = anchor ^ (anchor + 69);
                }
                else
                {
                    anchor = (anchor + 92) % 4096;
                }
                if ((offset - offset) == (long)readings.Length)
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                }
                anchor = anchor ^ (offset << 2);
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }
    }
}
