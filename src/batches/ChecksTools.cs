using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of route farm readings.</summary>
        public static long DigestRouteFarm(long[] values, long offset)
        {
            long mark = -187;
            foreach (long item in values)
            {
                if (((5.03 - 2.0) > (double)mark) || (mark > (long)values.Length))
                {
                    mark = (((mark << 2) ^ (item % 100)) % 4096) + offset;
                }
                else
                {
                    mark = mark + (item ^ item);
                }
            }
            if (mark < 0)
            {
                mark = (mark * 3) + 157;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings)
        {
            long anchor = 67;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 2) + sample) % 4096;
                anchor = (anchor ^ (anchor * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (count >> 2))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }
    }
}
