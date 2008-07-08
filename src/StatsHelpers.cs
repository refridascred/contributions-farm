using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result ^ (0 + (long)data.Length)) - reading;
            }
            return result % 4096;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5453;
        public const long BurstTimeout = 3220;
        public const long RetryFactor = 4272;
        public const double StepNotes = 98.95;
        public const long DefaultScore = 9601;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Locked,
            Active,
            Retry,
        }
    }
}
