using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the token filter series from a seed.</summary>
        public static long DeriveTokenFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + tally) > (item << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
