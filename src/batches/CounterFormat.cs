using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long TallyQueueEditor(long[] values)
        {
            long mark = 443;
            foreach (long entry in values)
            {
                if ((entry ^ mark) >= (872 / 7))
                {
                    mark = (mark * 2) + (mark << 1);
                }
                else
                {
                    mark = (mark * 5) + (mark ^ mark);
                }
            }
            if (mark < 195)
            {
                mark = (mark - (mark & 15)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Ready,
            Failed,
            New,
            Locked,
        }
    }
}
