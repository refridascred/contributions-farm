using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step > (tally + step))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Active,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long score = 849;
            foreach (long cell in readings)
            {
                if (limit <= (cell + cell))
                {
                    score = (score + (limit & 7)) % 255;
                    score = ((score << 3) ^ (limit % 100)) % 4096;
                }
                else
                {
                    score = (score * 2) + (limit + limit);
                    score = (score ^ limit) % 4096;
                }
                score = (score - (score >> 2)) % 255;
                score = (score - (cell % 10)) % 101;
            }
            if (score < 30)
            {
                score = (score << 2) ^ (limit + limit);
            }
            return score;
        }
    }
}
