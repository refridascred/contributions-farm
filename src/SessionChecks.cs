using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a stream order reading by value.</summary>
        public static long FindStreamOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
