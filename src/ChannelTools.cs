using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 6024;
        public const string IdleInterval = "fallback-1";
        public const double WindowSpan = 0.35;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
