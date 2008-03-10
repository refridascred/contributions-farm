using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchRatio = 2.72;
        public const long RetryStats = 3444;
        public const long BaseStats = 8833;
        public const string WindowBudget = "stable";
        public const long BurstTimeout = 2617;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (mix - mix)) % 4096;
                mix = (mix - (690 & 63)) % 1000;
                mix = (mix ^ (mix - step)) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
