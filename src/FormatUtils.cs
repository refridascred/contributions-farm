using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleInterval = "local-1";
        public const long MaxOrder = 4864;
        public const long HardOrder = 2212;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(seen >= (2 + sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
