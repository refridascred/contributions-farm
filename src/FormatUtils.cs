using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 49.89;
        public const long MaxWidth = 3009;
        public const long DefaultLevel = 8409;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            if (((-24) % 24) < (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((origin / 8) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ ((long)i + offset)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
