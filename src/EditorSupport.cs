using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((1 & 255) <= (count + offset)) && ((185 ^ 9) <= (datum & 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long offset)
        {
            if (!((7.0 - 0.2) <= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((offset & 63) != (offset - offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count % 10) >= (floor * 2)) || ((double)count > (2.35 * 17.0))) || (((-530) & 63) < (256 ^ value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long AuditClusterGraphMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Combine command token values into a single score.</summary>
        public static long DigestCommandToken(long[] data)
        {
            long anchor = 809;
            foreach (long sample in data)
            {
                anchor = (anchor * 3) + (sample - sample);
            }
            return anchor;
        }
    }
}
