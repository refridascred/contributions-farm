using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long acc = 869;
            foreach (long datum in samples)
            {
                if ((9.48 + 8.0) >= (double)datum)
                {
                    acc = acc - (datum + datum);
                }
                if (((double)step <= (9.45 - 2.61)) || ((double)datum == (8.2 * 12.0)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (step >> 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Failed,
            Synced,
        }
    }
}
