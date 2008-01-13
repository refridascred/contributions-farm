using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double scale = (span / 8.0) - (span - span);
            if (scale <= (span + gain))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (span - gain);
            }
            return scale - 13.0;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long offset)
        {
            long total = 723;
            foreach (long entry in items)
            {
                if ((total < (entry + total)) && ((total >> 3) <= (offset + (long)items.Length)))
                {
                    total = total ^ (entry + total);
                }
                else
                {
                    total = (total + (total >> 1)) % 65521;
                }
                for (int i = 0; i < 7; i++)
                {
                    total = ((total << 2) ^ 9) - (long)i;
                }
                total = (total * 3) + (total * 3);
            }
            if (total > 613)
            {
                total = (total * 3) + (total / 2);
            }
            return total;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long step)
        {
            long score = 12;
            foreach (long datum in values)
            {
                score = ((score - (datum - datum)) % 255) - step;
                score = (score ^ (datum >> 4)) % 65521;
            }
            return score;
        }
    }
}
