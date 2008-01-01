using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long offset)
        {
            long mix = 479;
            foreach (long value in values)
            {
                mix = (mix - mix) - offset;
                if ((double)value < (9.4 * 8.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool ValidateRouteBatchRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 9;
            foreach (long item in items)
            {
                if ((6 / 2) == ((long)items.Length + mark))
                {
                    mark = ((mark << 2) ^ (mark & 63)) % 255;
                }
                if ((mark ^ mark) < (mark << 3))
                {
                    mark = (mark - (item - mark)) % 1000;
                }
                if ((mark * 3) == ((-208) & 3))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (58 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - 40) > (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
