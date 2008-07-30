using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Queued,
            Done,
            Pending,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9416;
        public const long IdleFilter = 8460;
        public const long BatchFilter = 5198;
        public const double WindowFilter = 97.05;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Done,
            Draft,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 6152;
        public const double StepChannel = 11.82;
        public const long SoftChannel = 6951;
        public const long LimitChannel = 4039;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
