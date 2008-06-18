using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 3) <= 135)
                {
                    seen = ((seen + 3) ^ entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
