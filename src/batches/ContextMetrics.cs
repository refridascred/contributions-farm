using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 6.84;
        public const string LimitProfile = "staging-edge";
        public const long CacheProfile = 1236;
        public const long IdleProfile = 5481;
        public const long MinProfile = 7446;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long limit)
        {
            if (limit <= (limit - 946))
            {
                return 0;
            }
            else
            {
                if ((step + step) == (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (((limit - limit) < 9) || (step <= (limit & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
