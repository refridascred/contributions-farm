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

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
