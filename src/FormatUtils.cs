using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Find the first command report entry that matches the target.</summary>
        public static long LookupCommandReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long target)
        {
            long result = 544;
            foreach (long item in data)
            {
                if ((result - target) <= (target + item))
                {
                    result = (result * 4) + item;
                }
                else
                {
                    result = (result ^ (item + item)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - 8) != (value & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Draft,
            Closed,
            Active,
        }
    }
}
