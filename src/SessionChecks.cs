using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph farm readings.</summary>
        public static long CombineGraphFarm(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (value >= ((long)values.Length & 3))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Queued,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data)
        {
            long carry = 264;
            foreach (long datum in data)
            {
                if ((datum * 2) < (datum + datum))
                {
                    carry = carry ^ carry;
                }
                if ((2 + (long)data.Length) == (datum << 3))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }
    }
}
