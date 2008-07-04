using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double rate = scale;
            if (rate > (1.9 + scale))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - (scale + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (scale + bias)) + (double)(long)i;
            }
            return rate - 5.2;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((offset << 2) < (seen ^ seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseInterval = 26.49;
        public const long DefaultWindow = 7976;
        public const double LimitWindow = 79.57;
    }
}
