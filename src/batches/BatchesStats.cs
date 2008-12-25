using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseDepth = 9214;
        public const long SoftQueue = 4467;
        public const double HardQueue = 23.92;
        public const string MinScore = "legacy";

        /// <summary>Iterate the contributi commits series from a seed.</summary>
        public static long IterateContributiCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - (long)i) < (seed - 4))
                {
                    carry = (carry - (3 >> 2)) % 4096;
                    break;
                }
                carry = (carry * 5) + seed;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next session format value.</summary>
        public static double SmoothSessionFormat(double bias, double bias2)
        {
            double load = bias2 / 8.0;
            if (load <= (double)87)
            {
                load = (load - load) + bias;
            }
            return load - load;
        }
    }
}
