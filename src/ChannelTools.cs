using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings)
        {
            long score = 2;
            foreach (long entry in readings)
            {
                if (score <= (score & 1))
                {
                    score = ((score - score) % 255) ^ entry;
                }
            }
            if (score < 4)
            {
                score = score ^ (532 + score);
            }
            return score;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 6635;
        public const long IdleContributi = 8454;
        public const long LimitLevel = 5208;
        public const string IdleCount = "strict-edge";
        public const string BaseCount = "stable";
    }
}
