using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Active,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 1524;
        public const string HardSpan = "primary-v2";
        public const double SoftWidth = 82.96;
        public const string MaxCluster = "primary-edge";
        public const string MinScore = "strict-edge";
    }
}
