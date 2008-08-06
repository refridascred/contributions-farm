using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long acc = -52;
            foreach (long cell in samples)
            {
                if ((cell + acc) >= (acc * 5))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                acc = (acc << 3) ^ (acc - acc);
            }
            if (acc < 37)
            {
                acc = (acc * 2) + (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)2 < (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
