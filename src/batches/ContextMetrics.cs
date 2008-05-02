using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of queue account readings.</summary>
        public static long MatchQueueAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes cache samples.</summary>
        public static long WeighNotesCache(long[] samples)
        {
            long mark = 765;
            foreach (long datum in samples)
            {
                if ((double)datum < (9.0 + 7.0))
                {
                    mark = mark ^ (mark * 5);
                }
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxFactor = 109;
        public const long DefaultTools = 9158;
        public const double CacheCount = 51.48;
        public const long SoftDepth = 6457;
        public const long RetryTools = 3722;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
