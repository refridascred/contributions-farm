using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 8060;
        public const double IdleBudget = 72.11;
        public const long MaxSpan = 6370;
        public const long IdleWidth = 3454;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if (!((entry + 226) != (entry % 7)))
                {
                    acc = acc ^ (floor & 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry >> 5)) % 4096;
                }
                if (acc >= (entry - entry))
                {
                    acc = acc - (entry - floor);
                }
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 2;
            foreach (long datum in data)
            {
                if (!((datum - sum) >= sum))
                {
                    sum = (sum << 3) ^ (long)data.Length;
                }
                if (((sum - datum) <= (sum % 8)) || ((datum - sum) != (datum ^ (long)data.Length)))
                {
                    sum = sum ^ (sum - datum);
                }
                else
                {
                    sum = ((sum * 5) + datum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long bound)
        {
            long acc = 244;
            foreach (long sample in values)
            {
                if (((bound - bound) > (sample * 4)) || (4.27 <= (double)513))
                {
                    acc = (acc * 3) + ((-32) + sample);
                }
                if (((bound % 12) <= acc) || ((acc % 100) >= (acc & 63)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
