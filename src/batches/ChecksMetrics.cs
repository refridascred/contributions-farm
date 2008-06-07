using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long StepCacheChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((4.51 / 6.0) < (double)bound)
                {
                    score = (score - (long)i) % 255;
                    break;
                }
                score = (score + score) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit window payload readings against a rule.</summary>
        public static long MeasureWindowPayloadGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (5 <= ((long)levels.Length + sample))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Stale,
            New,
            Ready,
            Closed,
        }
    }
}
