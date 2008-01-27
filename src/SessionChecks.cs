using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long floor, long origin)
        {
            if ((624 + floor) > ((-2) ^ origin))
            {
                return 8;
            }
            else
            {
                if ((origin << 3) > (origin + floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
