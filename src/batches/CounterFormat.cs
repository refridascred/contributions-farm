using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= 8.3)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long score = 36;
            foreach (long datum in data)
            {
                score = (score ^ 911) % 97;
                if ((datum % 5) >= (long)data.Length)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 4) + (score >> 5)) % 101;
            }
            return score;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long result = 32;
            foreach (long entry in series)
            {
                if ((0.3 - 4.0) <= (double)entry)
                {
                    result = result + (origin * 3);
                }
                else
                {
                    result = result ^ origin;
                }
                if ((270 * 2) > result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
