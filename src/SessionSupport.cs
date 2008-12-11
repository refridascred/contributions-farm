using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (((anchor ^ anchor) >= (968 - 37)) || ((step * 3) <= (step % 12)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long SeriesMetricsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((total ^ total) == (offset + total)))
                {
                    total = total + total;
                    total = ((total << 3) ^ (long)i) % 97;
                }
                if (((82 % 60) > (total << 3)) || (15.0 >= (double)offset))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((4 + 469) > count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
