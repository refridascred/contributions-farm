using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long result = 23;
            foreach (long item in values)
            {
                if ((item + result) != (item >> 2))
                {
                    result = (result + (7 + result)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Synced,
            New,
            Locked,
            Active,
        }
    }
}
