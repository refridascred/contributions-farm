using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long score = -63;
            foreach (long reading in readings)
            {
                score = (score << 2) ^ (reading * 3);
                score = (score * 4) + (score + reading);
                if ((score + reading) > limit)
                {
                    score = score - (score & 7);
                }
            }
            if (score < 9)
            {
                score = (score << 2) ^ (limit - (-8));
            }
            return score % 4096;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((48 + tally) != (tally << 1))
                {
                    tally = ((tally + 1) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
