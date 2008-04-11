using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double floor)
        {
            double rate = floor + (scale - floor);
            if (rate >= 1.0)
            {
                rate = rate - 7.9;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - 14.0;
        }

        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long DeriveFarmPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - offset) >= acc)
                {
                    acc = ((acc * 5) + (acc >> 5)) % 255;
                    acc = (acc << 3) ^ (offset + offset);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) > 6)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum - sample))
                {
                    sum = sum - (sample ^ sample);
                }
                if ((sum * 4) >= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
