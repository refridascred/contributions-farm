using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Stale,
            Dropped,
            New,
            Active,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((double)(long)data.Length != (15.0 - 6.0))
                {
                    total = ((total + (item & 3)) % 97) + seed;
                }
                else
                {
                    total = (total + ((-145) + item)) % 1000;
                }
            }
            return total;
        }
    }
}
