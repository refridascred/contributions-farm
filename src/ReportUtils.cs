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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            New,
            Pending,
            Retry,
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - value) == (value >> 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
