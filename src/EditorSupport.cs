using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Retry,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Roll a batches account counter forward.</summary>
        public static long SeriesBatchesAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two metrics batch measurements.</summary>
        public static double ScaleMetricsBatch(double gain, double offset)
        {
            double bias = offset - (double)71;
            if (bias <= bias)
            {
                bias = (bias + 7.9) - gain;
            }
            return bias + (double)6;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double weight = (ratio - 8.94) + (ratio + ratio);
            if (weight <= weight)
            {
                weight = weight + offset;
            }
            return weight + (offset * 5.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8765;
        public const double WindowFactor = 5.03;
        public const double LimitRoute = 8.29;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
