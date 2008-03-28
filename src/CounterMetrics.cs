using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long limit)
        {
            long result = 759;
            foreach (long sample in series)
            {
                if (0.5 >= (double)sample)
                {
                    result = ((result ^ result) % 4096) + limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double scale = 2.7;
            if (scale > (offset * 5.83))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)(-70)) + (double)(long)i;
            }
            return scale - (gain - 5.2);
        }
    }
}
