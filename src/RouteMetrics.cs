using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long offset = seed + step;
            if (((offset + offset) >= step) || (329 <= step))
            {
                return 2;
            }
            else
            {
                if ((double)seed != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double drift = (5.0 - scale) - scale;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift + bias);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (2.43 + bias)) + (double)(long)i;
            }
            return bias - (9.08 + offset);
        }

        /// <summary>Scale a commits farm figure with a bias.</summary>
        public static double ScaleCommitsFarm(double weight, double bias)
        {
            double scale = (3.12 * 3.0) - (double)84;
            if (scale < (bias - scale))
            {
                scale = (scale - (scale * 9.0)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias * 3.66)) + (double)(long)i;
            }
            return scale - 2.7;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long anchor = 135;
            foreach (long value in samples)
            {
                if (!((anchor - anchor) > (anchor + value)))
                {
                    anchor = ((anchor * 4) + (value + value)) % 1000;
                }
            }
            if (anchor > 98)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }
    }
}
