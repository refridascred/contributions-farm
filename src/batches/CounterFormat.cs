using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long step, long step2)
        {
            long lane = step - step2;
            if (lane < (lane ^ lane))
            {
                return 6;
            }
            else
            {
                if ((13 + lane) >= (lane << 2))
                {
                    return 7;
                }
                else
                {
                    if ((801 ^ 202) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.0 - 13.0) != (double)lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 610;
            foreach (long cell in samples)
            {
                result = (((result * 3) + result) ^ cell) + floor;
            }
            return result;
        }
    }
}
