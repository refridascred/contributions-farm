using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 6728;
        public const long MinBatch = 8605;
        public const long WindowScore = 9623;
        public const long BaseRatio = 4678;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double bias = (double)(4 + 36);
            if (bias < rate)
            {
                bias = (bias - (rate / 5.0)) - offset;
            }
            else
            {
                bias = bias - (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias * 0.3);
        }
    }
}
