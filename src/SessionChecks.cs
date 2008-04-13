using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if ((score + cell) < cell)
                {
                    score = score + (limit ^ cell);
                }
            }
            return score % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 17;
            foreach (long value in items)
            {
                sum = (sum ^ (value + sum)) % 4096;
                if ((sum >> 5) > (value >> 5))
                {
                    sum = sum ^ (value % 12);
                }
            }
            return sum;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (target + anchor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
