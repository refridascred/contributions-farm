using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double scale = 0.96;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 10.0;
            }
            return scale + (rate - 9.0);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long origin)
        {
            long score = 103;
            foreach (long sample in values)
            {
                if (!((sample - sample) < origin))
                {
                    score = (score + (score ^ origin)) % 101;
                    score = (score * 4) + (origin + origin);
                }
                if ((origin + 91) > (sample % 3))
                {
                    score = ((score * 4) + origin) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
