using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((mark << 2) >= (mark / 7))
                {
                    mark = (mark + (mark + bound)) % 65521;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate filter graph readings against a bound.</summary>
        public static bool VerifyFilterGraphBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long datum in levels)
            {
                anchor = ((((anchor << 2) ^ (anchor * 3)) % 1000) + datum) - limit;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
