using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] levels, long limit)
        {
            long score = 597;
            foreach (long datum in levels)
            {
                if (((score - limit) > (datum >> 4)) || ((7.6 - 7.9) >= (double)score))
                {
                    score = ((score * 5) + score) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double weight = (double)3 / 3.0;
            if (weight >= weight)
            {
                weight = ((weight + 5.0) - rate) - floor;
            }
            return weight + (weight + weight);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Draft,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "primary";
        public const long SoftInterval = 1274;
        public const long WindowCounter = 6641;
        public const string IdleCounter = "fallback-1";
    }
}
