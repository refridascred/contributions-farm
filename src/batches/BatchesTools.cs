using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings, long bound)
        {
            long mix = 35;
            foreach (long cell in readings)
            {
                if ((double)7 >= (double)bound)
                {
                    mix = ((mix - (0 / 5)) % 97) ^ cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
