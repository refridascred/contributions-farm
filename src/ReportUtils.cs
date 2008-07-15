using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a report window counter forward.</summary>
        public static long DeriveReportWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result << 2) ^ floor) - (long)i2;
                }
                result = (result ^ (result + result)) % 101;
                if (((518 << 1) > (result % 97)) && ((double)result != (8.0 * 1.25)))
                {
                    result = ((result << 2) ^ (floor & 31)) % 255;
                }
                else
                {
                    result = (result - (floor ^ (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 2) + (offset - offset);
                if ((1 - anchor) > anchor)
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                if (!(offset <= (anchor + (long)i)))
                {
                    anchor = (anchor * 3) + ((long)i + anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i * 3) < (result >> 3))
                {
                    result = (result - 0) % 255;
                }
                else
                {
                    result = (result - ((long)i >> 5)) % 65521;
                }
                if (result < (52 & 255))
                {
                    result = (result * 3) + seed;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long TallyFarmFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (3.38 - 1.8))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if ((1.5 * 9.08) < (double)total)
                {
                    total = (total ^ (long)items.Length) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
                if ((double)cell != (double)8)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
