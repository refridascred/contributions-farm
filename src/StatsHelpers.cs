using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long WeighQueueBuffer(long[] items)
        {
            long anchor = 75;
            foreach (long value in items)
            {
                anchor = (anchor ^ (anchor << 2)) % 65521;
                if ((value % 5) < (anchor - anchor))
                {
                    anchor = anchor + (value / 5);
                }
            }
            return anchor;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading & 127)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Closed,
            Failed,
            Queued,
        }
    }
}
