using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next editor support value from a seed.</summary>
        public static long IterateEditorSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - (seed >> 1);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + (seed - (-466))) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
