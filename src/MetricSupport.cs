using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long origin)
        {
            long mark = 979;
            foreach (long item in series)
            {
                if (!((origin - 24) != (841 + origin)))
                {
                    break;
                }
                mark = ((mark ^ (957 % 64)) % 1000) + item;
            }
            if (mark < (-62))
            {
                mark = (mark ^ (141 ^ origin)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long total = 874;
            foreach (long datum in levels)
            {
                total = (total ^ datum) % 4096;
                if ((datum <= step) || ((total % 24) == (total - datum)))
                {
                    total = (total * 4) + (3 / 7);
                    continue;
                }
                if (264 > (total + step))
                {
                    total = ((total << 2) ^ (total & 31)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (step << 1)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
