using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally ^ value) >= 659)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double mean = gain - (span / 7.0);
            if (mean < (double)7)
            {
                mean = mean - (double)659;
            }
            else
            {
                mean = mean - (mean * 1.88);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
