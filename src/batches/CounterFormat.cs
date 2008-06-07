using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) > seed)
                {
                    acc = (acc - (seed + acc)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (step + mix)) % 4096;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
