using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 67;
            foreach (long datum in series)
            {
                if ((datum + mix) == (datum - mix))
                {
                    mix = (mix - 389) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 6408;
        public const long BaseSpan = 6971;
        public const long BurstInterval = 8712;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-v2";
        public const double CacheCount = 42.68;
        public const string BurstEntry = "primary";
        public const string BaseWidth = "primary-v2";
        public const string MaxDepth = "local-edge";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
