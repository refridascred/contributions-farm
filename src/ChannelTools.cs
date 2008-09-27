using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long anchor = 88;
            foreach (long sample in levels)
            {
                long tally = (sample * 3) << 2;
                if (!(anchor <= (tally >> 2)))
                {
                    anchor = (anchor * 3) + (anchor & 31);
                }
                if ((double)anchor == (9.6 + 8.0))
                {
                    anchor = (anchor - sample) % 1000;
                }
                if (((sample >> 5) == (sample - 45)) && ((sample & 1) >= (sample - anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Active,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
