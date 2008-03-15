using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
