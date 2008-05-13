using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if (99 > (599 - mark))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Failed,
            New,
            Done,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((offset + offset) != (offset + 5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit > (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowSpan = "latest";
        public const string SoftInterval = "strict-1";
        public const long WindowFactor = 1323;
        public const long WindowReport = 3376;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftFactor = 8380;
        public const double IdleAlready = 51.54;
        public const double DefaultBudget = 55.79;

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long cell in samples)
            {
                acc = ((acc + (bound + bound)) % 97) + cell;
                acc = ((acc << 2) ^ (acc + 1)) % 65521;
            }
            return acc;
        }
    }
}
