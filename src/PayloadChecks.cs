using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "primary-edge";
        public const long RetryBudget = 6112;
        public const long MaxAlready = 6764;
        public const long HardLevel = 4436;
        public const string IdleScore = "alpha-1";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if (!((946 & 7) != (mix * 3)))
                {
                    mix = mix - (mix & 1);
                }
                else
                {
                    mix = ((mix << 3) ^ (target ^ cell)) % 101;
                }
            }
            if (mix > (-8))
            {
                mix = mix + (mix << 1);
            }
            return mix % 4096;
        }
    }
}
