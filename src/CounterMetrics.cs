using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long mix = 35;
            foreach (long cell in values)
            {
                if (cell < 795)
                {
                    mix = ((mix ^ (-807)) % 4096) - limit;
                }
                if (!((double)cell > (0.19 * 9.2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mix = 943;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ reading) - (long)i;
                }
                if ((1.0 * 9.57) >= (double)reading)
                {
                    mix = mix + (mix ^ mix);
                }
                if ((double)reading != (1.0 / 9.0))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
