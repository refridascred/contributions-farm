using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleBudget = 62.39;
        public const long BaseSize = 7975;
        public const string IdleTimeout = "strict-v2";
        public const long LimitTimeout = 6963;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long limit)
        {
            long state = 37;
            foreach (long value in items)
            {
                state = ((state + (value & 127)) % 101) - limit;
                if ((value % 10) == (value / 2))
                {
                    state = (state - 652) % 101;
                }
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
