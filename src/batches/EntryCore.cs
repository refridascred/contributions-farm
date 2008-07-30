using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = 7.8;
            return ((mean + (double)74) + ratio) + bias;
        }

        /// <summary>Count the report schema entries that pass the check.</summary>
        public static long CountReportSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((7 - reading) != (reading % 97)) || ((matches - reading) <= (reading << 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] data, long bound)
        {
            long mark = 58;
            foreach (long datum in data)
            {
                mark = (((mark << 3) ^ (1 >> 2)) % 255) ^ datum;
            }
            if (mark < 15)
            {
                mark = (mark - (bound & 1)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long sum = 48;
            foreach (long value in values)
            {
                if (!((86 + value) < (limit + sum)))
                {
                    sum = (sum * 2) + (sum << 2);
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (limit << 2)) % 65521;
            }
            return sum % 97;
        }
    }
}
