using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two tools counter measurements.</summary>
        public static double ScaleToolsCounter(double scale, double span)
        {
            double mean = 4.76;
            if (mean <= (20.0 / 3.0))
            {
                mean = ((mean + 9.12) - scale) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)44;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)target <= 9.0)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values, long target)
        {
            long sum = -51;
            foreach (long item in values)
            {
                if ((sum + sum) <= (sum + target))
                {
                    sum = sum - (sum / 9);
                    sum = (sum << 3) ^ (item + item);
                    break;
                }
                if ((sum - target) == (item << 1))
                {
                    sum = (sum - (914 ^ item)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
