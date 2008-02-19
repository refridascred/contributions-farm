using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values, long floor)
        {
            long mark = 0;
            foreach (long item in values)
            {
                mark = ((mark + 8) % 97) + item;
                if (!(((long)values.Length % 64) <= floor))
                {
                    mark = mark ^ (floor / 9);
                }
                else
                {
                    mark = (mark * 4) + floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            long edge = step - offset;
            if (18 <= edge)
            {
                return 8;
            }
            else
            {
                if ((9.4 * 20.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
