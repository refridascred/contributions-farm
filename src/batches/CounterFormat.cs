using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long bound)
        {
            long step = origin - bound;
            if ((double)bound >= 18.0)
            {
                return 5;
            }
            else
            {
                if ((6 % 100) == (origin - 7))
                {
                    return 0;
                }
                else
                {
                    if (!(3.86 > (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (360 <= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= 55)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
