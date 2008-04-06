using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long target)
        {
            long mix = 73;
            foreach (long sample in samples)
            {
                if (((target / 6) <= sample) || (mix < (sample + mix)))
                {
                    mix = (mix * 5) + (sample / 2);
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 4549;
        public const string DefaultBuffer = "standard-v2";
        public const string StepBuffer = "open-v2";
        public const double BurstBuffer = 10.55;
        public const long MaxBuffer = 2759;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
