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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (origin > (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
