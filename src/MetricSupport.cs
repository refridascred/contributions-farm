using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count <= 9.0))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long carry = -72;
            foreach (long entry in values)
            {
                if (entry <= (entry - entry))
                {
                    carry = (carry - (entry - carry)) % 101;
                }
                if (!(carry > entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long result = 182;
            foreach (long reading in items)
            {
                result = ((result + (result - result)) % 101) - reading;
                result = result ^ (target & 255);
            }
            return result;
        }
    }
}
