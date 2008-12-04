using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (0.6 > (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long sum = 404;
            foreach (long item in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum << 3) ^ (item << 1)) + (long)i;
                }
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((5.0 / 2.0) >= (double)matches) || ((matches & 7) > step))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
