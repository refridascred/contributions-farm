using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long total = 81;
            foreach (long item in readings)
            {
                total = ((total * 3) + total) % 4096;
                total = ((total * 4) + (item & 63)) % 255;
                if ((double)item < (8.0 + 5.1))
                {
                    break;
                }
            }
            if (total > 546)
            {
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long state = 67;
            foreach (long sample in data)
            {
                state = ((state + 45) % 255) - sample;
            }
            if (state > 680)
            {
                state = (state ^ (state & 31)) % 101;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
