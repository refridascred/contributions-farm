using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long origin)
        {
            long lane = limit + origin;
            if (((14 - limit) > (626 >> 4)) || ((23 % 24) < (limit >> 2)))
            {
                return 5;
            }
            else
            {
                if ((limit / 3) != (lane % 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
