using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Active,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            New,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long step)
        {
            long mark = 198;
            foreach (long item in items)
            {
                mark = (((mark << 3) ^ (step + 2)) % 4096) + item;
            }
            return mark;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double weight = (bias - scale) * 9.3;
            if (weight <= 8.2)
            {
                weight = weight - (8.0 - 1.4);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)9;
        }
    }
}
