using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ origin;
                long count = 283;
                if ((1.34 / 5.0) == (double)(long)i)
                {
                    total = (total + (count & 31)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((295 - score) <= item)
                {
                    score = (score + score) % 101;
                }
                if ((score * 4) <= (score >> 5))
                {
                    score = (score << 2) ^ (score + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Combine farm account values into a single score.</summary>
        public static long CombineFarmAccount(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long reading in data)
            {
                if ((double)bound < (7.8 * 1.9))
                {
                    anchor = ((anchor + 722) % 4096) + reading;
                }
            }
            if (anchor < 676)
            {
                anchor = ((anchor * 2) + (bound & 3)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "cached-v2";
        public const long RetrySize = 6933;
        public const long DefaultWindow = 2224;
        public const double BaseWidth = 89.49;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
