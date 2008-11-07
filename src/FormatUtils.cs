using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of cache contributi readings.</summary>
        public static long CombineCacheContributi(long[] data)
        {
            long mark = 824;
            foreach (long value in data)
            {
                if (value >= mark)
                {
                    mark = mark + (mark >> 3);
                }
                if ((((long)data.Length * 4) <= value) && (mark < (value / 2)))
                {
                    mark = (mark + value) % 97;
                    mark = mark + (502 + mark);
                }
                else
                {
                    mark = (mark * 3) + (570 ^ (-48));
                }
                if (!((71 - value) < mark))
                {
                    mark = mark ^ (value >> 4);
                }
            }
            if (mark > 921)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (7.0 >= (1.7 - 2.45))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 68.06;
        public const long SoftContributi = 506;
        public const long BatchSize = 6561;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally / 9) < (datum & 3))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics report readings against a bound.</summary>
        public static bool ValidateMetricsReportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
