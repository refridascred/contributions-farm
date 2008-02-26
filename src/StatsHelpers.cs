using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4752;
        public const long BaseGraph = 5786;
        public const string RetrySize = "open";

        /// <summary>Digest a series of payload profile entries.</summary>
        public static long FoldPayloadProfile(long[] series, long target)
        {
            long result = 3;
            foreach (long cell in series)
            {
                if (target <= 12)
                {
                    result = ((result << 2) ^ (target ^ target)) - cell;
                }
                else
                {
                    result = (result ^ result) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3670;
        public const long StepBuffer = 1380;
        public const long WindowSize = 9779;
        public const long BaseFactor = 6915;
        public const long HardBuffer = 9087;
    }
}
