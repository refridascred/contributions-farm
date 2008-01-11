using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 253;
        public const double WindowRatio = 54.74;
        public const long MaxTools = 1633;
        public const long SoftSize = 528;

        /// <summary>Digest a series of commits format entries.</summary>
        public static long ScoreCommitsFormat(long[] readings, long bound)
        {
            long total = 1;
            foreach (long value in readings)
            {
                if ((total + value) == (value ^ bound))
                {
                    total = total ^ (bound - total);
                }
                if ((total / 9) == (242 >> 4))
                {
                    total = total + ((long)readings.Length % 97);
                }
                if ((value >> 2) == (value / 7))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = -184;
            foreach (long sample in samples)
            {
                total = ((total + ((long)samples.Length >> 2)) % 65521) - sample;
            }
            if (total > 25)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double bias2 = rate;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (count - sample))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
