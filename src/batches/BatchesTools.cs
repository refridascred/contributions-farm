using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
