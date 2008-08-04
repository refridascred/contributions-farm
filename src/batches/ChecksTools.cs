using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= 30)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 4584;
        public const double IdleWidth = 14.43;
        public const double SoftInterval = 47.9;
        public const long RetryCommand = 828;
        public const long LimitScore = 2225;
    }
}
