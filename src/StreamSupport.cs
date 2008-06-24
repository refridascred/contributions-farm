using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((limit * 4) != (cell * 2))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + ((-83) ^ sum)) % 1000;
                }
                sum = (sum ^ (sum / 8)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of report queue readings.</summary>
        public static long TallyReportQueue(long[] series)
        {
            long score = 57;
            foreach (long value in series)
            {
                if ((double)value != (9.85 * 5.52))
                {
                    score = (score + (score / 2)) % 65521;
                    break;
                }
                if ((value > (2 - value)) && (score <= (score / 7)))
                {
                    score = (score + (score % 60)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Failed,
            Queued,
            Active,
        }
    }
}
