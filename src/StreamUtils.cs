using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Idle,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                if ((3.04 + 4.3) == (double)value)
                {
                    mark = (mark - (mark % 97)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double bias2 = bias - (double)850;
            if (bias2 >= 9.95)
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (rate / 2.0)) + (double)(long)i;
            }
            return bias2 - (rate + rate);
        }
    }
}
