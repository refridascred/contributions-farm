using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double rate = weight + weight;
            if (rate > rate)
            {
                rate = (rate - 3.96) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight - rate)) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)seed < 3.93)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= ((long)values.Length + sample))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format route samples.</summary>
        public static long TotalFormatRoute(long[] series)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                if ((5.52 / 9.0) > (double)cell)
                {
                    mark = (mark * 2) + (cell + cell);
                }
                else
                {
                    mark = ((mark << 3) ^ (cell - (-6))) % 65521;
                }
                mark = ((mark * 5) + (42 ^ mark)) % 255;
                if (cell <= (cell + cell))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (9 >> 4)) % 255;
            }
            return mark % 65521;
        }
    }
}
