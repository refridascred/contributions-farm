using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (step & 15)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
