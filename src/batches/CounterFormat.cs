using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
