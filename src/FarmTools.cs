using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((1.3 / 2.0) >= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7 <= (value + value)) && ((count & 3) < (33 << 3)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
