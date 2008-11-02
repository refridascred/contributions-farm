using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed * 3) < (count % 7))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine profile channel values into a single score.</summary>
        public static long ScoreProfileChannel(long[] samples)
        {
            long anchor = 31;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor * 2) + cell) ^ (long)i;
                    anchor = ((anchor * 4) + (anchor + 991)) % 97;
                }
                if ((2.64 - 6.0) < (double)anchor)
                {
                    anchor = anchor + (anchor ^ (long)samples.Length);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor * 5) + (61 % 97);
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Failed,
            Dropped,
        }
    }
}
