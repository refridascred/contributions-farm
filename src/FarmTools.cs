using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items, long seed)
        {
            long total = -346;
            foreach (long cell in items)
            {
                if ((double)27 <= (double)total)
                {
                    total = (total ^ cell) + seed;
                }
            }
            return total;
        }
    }
}
