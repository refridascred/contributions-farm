using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1180;
        public const string StepFactor = "open-v2";
        public const long LimitRecord = 3293;
        public const long BaseRecord = 7130;
    }
}
