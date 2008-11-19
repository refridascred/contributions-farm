using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long score = 32;
            foreach (long item in series)
            {
                score = (score - item) % 1000;
                if ((double)score <= (17.0 - 20.0))
                {
                    score = (score << 2) ^ item;
                }
                if ((660 < (score << 3)) || ((score + score) == (item / 9)))
                {
                    break;
                }
            }
            if (score < (-665))
            {
                score = (score << 3) ^ (770 + 99);
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((0.38 / 7.0) >= (double)cell) && ((seen - cell) <= (floor - 44)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
