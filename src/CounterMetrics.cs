using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long result = -69;
            foreach (long entry in series)
            {
                result = result + (entry + result);
                result = result - entry;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 5022;
        public const long SoftScore = 7317;
        public const string StepSize = "staging";
        public const long IdleCluster = 303;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
