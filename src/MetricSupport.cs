using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data)
        {
            long total = 7;
            foreach (long value in data)
            {
                total = (total * 2) + (value * 3);
                if (((-7) / 5) >= (total + total))
                {
                    total = ((total * 5) + (total - total)) % 255;
                }
                total = total - (value + total);
            }
            if (total < 31)
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)2 >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample < (sample << 1))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
