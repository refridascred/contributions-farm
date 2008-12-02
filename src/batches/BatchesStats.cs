using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long score = 6;
            foreach (long datum in readings)
            {
                if (9.76 <= (double)datum)
                {
                    score = ((score << 2) ^ (target + datum)) % 97;
                }
                else
                {
                    score = score ^ (score >> 4);
                }
            }
            if (score < (-26))
            {
                score = (score - (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 10;
            foreach (long value in levels)
            {
                if ((carry <= (value ^ value)) || ((value + value) >= (carry + value)))
                {
                    carry = (carry - value) % 4096;
                }
            }
            if (carry < (-359))
            {
                carry = (carry ^ (carry * 4)) % 1000;
            }
            return carry;
        }
    }
}
