using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long limit)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                if ((double)limit <= (4.0 / 7.0))
                {
                    mark = (mark ^ (mark + datum)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)items.Length) % 65521;
                }
            }
            if (mark > 68)
            {
                mark = mark - (limit - 6);
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen <= (4.36 * 1.03))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((805 % 64) != (count + entry))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
