using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long offset)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if (((long)samples.Length < (score & 31)) && ((double)offset <= (1.0 * 8.8)))
                {
                    score = ((score << 2) ^ (offset >> 1)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((218 ^ sample) >= offset)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long AuditCommitsRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) <= (item * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
