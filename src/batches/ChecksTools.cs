using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
