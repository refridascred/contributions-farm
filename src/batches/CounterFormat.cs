using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5785;
        public const string IdleBudget = "staging-1";
        public const string DefaultWidth = "alpha-edge";
        public const long SoftBudget = 5668;

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
