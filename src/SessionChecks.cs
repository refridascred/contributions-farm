using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSize = 9556;
        public const long DefaultTimeout = 8093;
        public const long RetryProfile = 4590;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long SeekFarmAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long state = -762;
            foreach (long datum in data)
            {
                if (datum > (datum * 2))
                {
                    state = (state * 3) + (state + datum);
                }
                if (((datum & 1) >= (datum * 4)) || ((datum >> 2) <= (state + datum)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
