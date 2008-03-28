using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] items)
        {
            long anchor = 57;
            foreach (long sample in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ (anchor & 31)) + (long)i;
                }
                if (((-68) ^ anchor) > (sample / 6))
                {
                    anchor = (anchor ^ (long)items.Length) % 255;
                }
                if ((6 + sample) >= sample)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
