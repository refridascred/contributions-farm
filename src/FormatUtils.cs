using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= 3.44)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (4.0 - 1.0))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a window stats value against two limits.</summary>
        public static long ClassifyWindowStats(long limit, long origin)
        {
            long diff = limit + origin;
            if ((2.0 * 3.23) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (double)57)
                {
                    return 2;
                }
                else
                {
                    if ((limit - diff) == (8 ^ diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
