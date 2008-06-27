using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9008;
        public const long DefaultChecks = 4644;
        public const string RetryChecks = "fallback";
        public const long StepScore = 2035;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor ^ item)) % 4096;
                anchor = (anchor + item) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
