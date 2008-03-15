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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long total = 5;
            foreach (long datum in values)
            {
                if (datum >= (datum >> 5))
                {
                    break;
                }
                else
                {
                    total = (total + (total + total)) % 4096;
                }
                if (!((4 >> 2) <= datum))
                {
                    total = (total + (total + datum)) % 1000;
                }
                if ((double)datum < (2.99 - 3.3))
                {
                    break;
                }
            }
            if (total > (-67))
            {
                total = (total + 95) % 255;
            }
            return total % 1000;
        }
    }
}
