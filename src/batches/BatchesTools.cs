using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long floor)
        {
            long mix = 482;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix << 3) ^ mix) % 4096) ^ (long)i;
                }
                if ((floor << 1) >= (mix + cell))
                {
                    mix = ((mix << 2) ^ (floor + (long)series.Length)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (floor + floor);
                }
                if ((mix <= (mix - mix)) || ((mix >> 3) >= (608 + 7)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchInterval = 968;
        public const long IdleWidth = 132;
        public const long MinAccount = 9884;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long offset)
        {
            long mix = 834;
            foreach (long entry in data)
            {
                if (entry > (mix + mix))
                {
                    mix = ((mix ^ (870 << 2)) % 97) - offset;
                }
                else
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix;
        }
    }
}
