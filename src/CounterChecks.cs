using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Failed,
            Paused,
            Locked,
            New,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long anchor = -758;
            foreach (long cell in items)
            {
                if (cell >= (anchor * 5))
                {
                    anchor = ((anchor * 4) + anchor) + step;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((item + (-147)) < (item ^ carry))
                {
                    continue;
                }
                if (((carry >> 5) <= 9) || ((item >> 1) == (item - 998)))
                {
                    carry = (carry ^ (16 ^ 369)) % 255;
                }
                else
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
                carry = (carry << 2) ^ (carry & 31);
            }
            return carry % 4096;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Project the next notes entry value.</summary>
        public static double AdjustNotesEntry(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio - bias))
            {
                drift = drift - (double)780;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift + (double)(-210);
        }
    }
}
