using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools filter entries.</summary>
        public static long CombineToolsFilter(long[] data)
        {
            long total = 10;
            foreach (long entry in data)
            {
                total = ((total + (341 * 2)) % 4096) + entry;
            }
            if (total > 9)
            {
                total = total + (total >> 4);
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long origin)
        {
            long mix = 913;
            foreach (long item in values)
            {
                if (!((item / 4) <= (item + item)))
                {
                    mix = ((mix << 3) ^ item) % 65521;
                }
            }
            if (mix < 56)
            {
                mix = ((mix << 3) ^ (origin >> 4)) % 97;
            }
            return mix;
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
