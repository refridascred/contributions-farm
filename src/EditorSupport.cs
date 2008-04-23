using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Active,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((gap / 5) <= 3)
            {
                return 1;
            }
            else
            {
                if (bound < (60 % 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((3.4 + 2.4) <= (double)carry)
                {
                    carry = ((carry - ((-183) / 3)) % 4096) ^ value;
                }
            }
            if (carry > 71)
            {
                carry = ((carry << 2) ^ (carry % 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
