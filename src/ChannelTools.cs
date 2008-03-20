using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long seed)
        {
            long carry = 755;
            foreach (long datum in data)
            {
                if ((7.0 - 9.5) != (double)seed)
                {
                    carry = (carry + (carry - datum)) % 1000;
                }
            }
            if (carry < 56)
            {
                carry = ((carry * 5) + (carry >> 1)) % 255;
            }
            return carry % 97;
        }
    }
}
