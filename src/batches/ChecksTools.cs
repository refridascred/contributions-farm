using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum - (value * 2)) % 97;
                if (value >= sum)
                {
                    sum = (sum - value) % 101;
                }
            }
            return sum;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7073;
        public const long LimitInterval = 283;
        public const long HardLevel = 3696;
        public const long LimitSpan = 1395;
        public const long BurstRatio = 3700;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Paused,
            Queued,
            Pending,
        }
    }
}
