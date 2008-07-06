using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxSize = "local-1";
        public const double HardCommand = 80.58;
        public const long BaseInterval = 4107;
        public const long DefaultDepth = 6356;
        public const long SoftCommand = 973;

        /// <summary>Look up the position of a command metrics sample.</summary>
        public static long LookupCommandMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((floor << 3) <= floor)
            {
                return 1;
            }
            else
            {
                if ((floor / 4) > (945 - seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 3) <= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
