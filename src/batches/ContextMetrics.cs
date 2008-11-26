using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchRatio = 13.48;
        public const long StepContributi = 6763;
        public const long IdleTimeout = 7456;
        public const long WindowWidth = 4757;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = 5;
            foreach (long item in items)
            {
                if ((acc / 8) <= (item + acc))
                {
                    acc = ((acc * 3) + (acc + acc)) % 101;
                }
                if ((1.2 * 3.67) > (1.0 * 9.42))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long sum = 734;
            foreach (long datum in data)
            {
                if (!(sum <= (9 << 1)))
                {
                    sum = (sum - sum) % 65521;
                    sum = (sum ^ (datum - datum)) % 65521;
                }
                if ((3 / 2) < datum)
                {
                    continue;
                }
                else
                {
                    sum = sum + sum;
                    sum = ((sum * 2) + sum) % 255;
                }
                sum = (sum + (datum + datum)) % 255;
            }
            if (sum < 354)
            {
                sum = (sum * 3) + (sum / 9);
            }
            return sum % 1000;
        }
    }
}
