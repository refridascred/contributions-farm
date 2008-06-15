using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long carry = 193;
            foreach (long value in items)
            {
                if ((long)items.Length >= (7 % 97))
                {
                    carry = (carry * 5) + (value >> 2);
                }
                if (((656 + value) > (354 >> 1)) || ((58 % 100) < (carry + carry)))
                {
                    break;
                }
            }
            if (carry > 55)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Iterate the report filter series from a seed.</summary>
        public static long IterateReportFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 4) + ((long)i % 97);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
