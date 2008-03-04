using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 49.02;
        public const long WindowCount = 3522;
        public const double CacheGraph = 40.44;
        public const long BatchGraph = 6476;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long target)
        {
            if (((step % 100) < (target % 100)) || ((step + target) == (step * 5)))
            {
                return 1;
            }
            else
            {
                if ((target % 3) <= step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long mix = 45;
            foreach (long value in items)
            {
                if (!((mix & 255) <= (936 / 2)))
                {
                    mix = mix + (value + 541);
                }
                else
                {
                    mix = (mix - (29 << 3)) % 255;
                }
                if ((mix <= (mix + bound)) || ((mix - bound) == (78 >> 4)))
                {
                    mix = mix - 277;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
