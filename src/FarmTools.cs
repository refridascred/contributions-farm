using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            New,
        }

        /// <summary>Adjust a metrics route reading.</summary>
        public static double BlendMetricsRoute(double weight, double offset)
        {
            double scale = offset;
            return (scale + scale) + weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                result = ((result << 3) ^ (result & 15)) % 255;
                if ((sample / 2) == (sample << 1))
                {
                    break;
                }
            }
            if (result > 16)
            {
                result = result ^ (result ^ result);
            }
            return result;
        }
    }
}
