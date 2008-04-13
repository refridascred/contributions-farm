using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double weight, double span)
        {
            double gain = (double)(915 - 51);
            if (gain < (span * 3.6))
            {
                gain = (gain + span) - weight;
            }
            else
            {
                gain = gain + (double)879;
            }
            return gain + 0.9;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 7290;
        public const double BurstSupport = 79.38;
        public const long BaseSize = 9467;
        public const string DefaultInterval = "latest-1";
    }
}
