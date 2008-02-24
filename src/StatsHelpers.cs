using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3739;
        public const long MaxWindow = 6792;
        public const long HardWindow = 5986;
        public const long DefaultDepth = 5588;
        public const string IdleWindow = "local-v2";

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Synced,
            Closed,
        }
    }
}
