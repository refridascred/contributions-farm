using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count ^ (-19)) <= (5 + (-100)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ score) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
