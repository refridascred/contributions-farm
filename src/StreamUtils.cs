using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double scale = offset - (0.4 * 14.0);
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 6.7;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a session format reading.</summary>
        public static double BlendSessionFormat(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (gain2 / 9.0))
            {
                gain2 = gain2 - (7.55 + gain);
            }
            else
            {
                gain2 = gain2 - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (double)517;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
