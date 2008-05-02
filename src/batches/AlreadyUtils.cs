using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long origin)
        {
            long span = limit - origin;
            if ((4 & 1) != (span ^ span))
            {
                return 1;
            }
            else
            {
                if ((span + origin) >= (6 - span))
                {
                    return 5;
                }
                else
                {
                    if (((origin & 31) < limit) || ((double)span >= (double)96))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate channel layout samples.</summary>
        public static long TallyChannelLayout(long[] series)
        {
            long mark = 6;
            foreach (long sample in series)
            {
                if ((double)sample <= (13.0 + 18.0))
                {
                    mark = (mark << 3) ^ (mark << 3);
                }
            }
            if (mark < (-859))
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
