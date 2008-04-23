using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = (double)374 - (ratio * 11.0);
            if (scale >= ratio)
            {
                scale = scale + (ratio * 1.8);
            }
            else
            {
                scale = scale - (double)20;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (8.8 < (double)origin)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double bias = offset * 0.46;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + bias) + (double)(long)i) - gain;
            }
            return bias - (offset * 1.9);
        }
    }
}
