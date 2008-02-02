using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long sum = 84;
            foreach (long cell in values)
            {
                sum = (sum + (cell >> 4)) - seed;
            }
            if (sum < 54)
            {
                sum = sum - 62;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = (((result * 3) + (result * 3)) % 255) - value;
            }
            return result;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double offset)
        {
            double load = (gain + offset) * 7.9;
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (load * 7.7);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 467;
            foreach (long datum in series)
            {
                state = state - (datum + state);
            }
            if (state > 57)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
