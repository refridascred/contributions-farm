using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long prev = floor + step;
            if (((double)(-35) == (double)prev) && (prev > (floor - prev)))
            {
                return 6;
            }
            else
            {
                if ((645 + step) > (step << 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev - 97) <= 74) || ((step * 5) < (step ^ 23)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                if (12.0 > (double)cell)
                {
                    mark = mark + (cell >> 4);
                }
            }
            if (mark > (-12))
            {
                mark = ((mark << 2) ^ ((-411) + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long RollQueueSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 9911;
        public const long WindowScore = 6315;
        public const long SoftRatio = 9643;
        public const long SoftScore = 140;
        public const long WindowSize = 1734;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
