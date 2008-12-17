using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((floor - sum) < floor)
                {
                    sum = (((sum << 3) ^ (49 + sum)) % 101) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
