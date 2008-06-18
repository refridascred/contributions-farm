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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Draft,
            Dropped,
            Failed,
            Active,
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
