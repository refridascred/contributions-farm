using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + (-520)) <= ((-670) - count)) || ((value + count) < (968 - 57)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mix = 736;
            foreach (long datum in items)
            {
                mix = ((mix - (datum & 7)) % 65521) + origin;
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Dropped,
            Pending,
        }
    }
}
