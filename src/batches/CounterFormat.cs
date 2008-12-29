using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 308;
            foreach (long value in items)
            {
                if ((double)total <= (3.2 + 4.1))
                {
                    total = ((total + (total - total)) % 101) - value;
                }
                else
                {
                    total = total + (total % 100);
                }
            }
            if (total < 3)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
