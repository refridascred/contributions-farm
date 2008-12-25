using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            New,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - (origin * 4)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9244;
        public const long BatchInterval = 6263;
        public const long DefaultSchema = 8221;
        public const long SoftDepth = 9627;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double gain = scale;
            if (gain > (double)7)
            {
                gain = gain + (gain * 5.68);
            }
            return gain - offset;
        }
    }
}
