using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstBudget = 29.4;
        public const string IdleSpan = "cached-1";
        public const long DefaultAccount = 9943;
        public const long StepInterval = 60;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a stream graph sample.</summary>
        public static long LocateStreamGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
