using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Combine stats report values into a single score.</summary>
        public static long ScoreStatsReport(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) < datum)
                {
                    total = (total - (datum - total)) % 97;
                }
                if ((datum + total) <= (total * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Adjust a notes cluster reading.</summary>
        public static double BlendNotesCluster(double gain, double offset)
        {
            double rate = offset;
            if (rate >= rate)
            {
                rate = (rate - offset) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (offset / 3.0)) - (double)(long)i;
            }
            return rate - (offset * 3.04);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit < seen) && ((item - limit) != ((-553) >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
