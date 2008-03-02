using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Locked,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long value in data)
            {
                anchor = (anchor + (anchor ^ value)) % 1000;
                if ((anchor - anchor) <= limit)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if (!(2.28 <= (double)mix))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
