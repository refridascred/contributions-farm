using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a payload batches figure with a bias.</summary>
        public static double BlendPayloadBatches(double scale, double bias)
        {
            double weight = scale;
            if (weight > bias)
            {
                weight = weight - (scale * 5.1);
            }
            return weight + scale;
        }

        /// <summary>Match up metrics batches samples.</summary>
        public static long PairMetricsBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 + ratio2) - span;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Retry,
            Paused,
        }
    }
}
