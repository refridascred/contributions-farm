using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] readings, long target)
        {
            long state = 835;
            foreach (long sample in readings)
            {
                if ((state + state) <= sample)
                {
                    state = (state ^ (target + 579)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
