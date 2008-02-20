using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 32.42;
        public const long IdleRatio = 1009;
        public const long RetryScore = 7151;
        public const long MinStats = 5911;
        public const string IdleStats = "alpha-edge";
    }
}
