using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                if (datum <= (state >> 2))
                {
                    state = ((state << 3) ^ (state & 63)) % 255;
                }
                if ((311 + 9) > state)
                {
                    break;
                }
            }
            if (state > 53)
            {
                state = (state << 2) ^ 6;
            }
            return state;
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
