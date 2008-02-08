using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 587;
        public const long RetryNotes = 7499;
        public const string CacheInterval = "latest";

        /// <summary>Blend two order tools measurements.</summary>
        public static double ProjectOrderTools(double scale, double bias)
        {
            double load = bias;
            if (load > (7.0 / 3.0))
            {
                load = load - (double)200;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (scale - bias)) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }
    }
}
