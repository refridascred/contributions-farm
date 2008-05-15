using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a queue filter sample.</summary>
        public static long FindQueueFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (target < (value & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long score = 67;
            foreach (long datum in items)
            {
                if (((datum % 10) < (datum / 2)) || (limit <= (188 * 2)))
                {
                    score = score ^ datum;
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (5 << 1)) % 97;
                }
                score = score + (limit >> 4);
            }
            return score % 65521;
        }
    }
}
