using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            long step2 = limit - step;
            if (limit <= step2)
            {
                return 5;
            }
            else
            {
                if (((-45) + limit) < (step << 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit - step2) < (step2 ^ limit)) || (step2 > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (limit + 323))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 2) <= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
