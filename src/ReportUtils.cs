using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Active,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (31 + (long)i)) % 97;
                carry = carry - (carry + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
