using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Synced,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples)
        {
            long sum = 898;
            foreach (long value in samples)
            {
                if ((0.25 + 15.0) > (double)sum)
                {
                    sum = ((sum << 3) ^ sum) + value;
                }
            }
            if (sum < 773)
            {
                sum = ((sum << 3) ^ ((long)samples.Length % 24)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
