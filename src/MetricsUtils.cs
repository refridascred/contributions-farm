using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Stale,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values, long floor)
        {
            long sum = 8;
            foreach (long item in values)
            {
                if (!((sum ^ item) != (floor + 55)))
                {
                    sum = sum - (-1);
                }
            }
            if (sum < 97)
            {
                sum = ((sum << 2) ^ (floor - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 5872;
        public const string MaxTimeout = "staging";
        public const long LimitContext = 8728;
        public const double IdleBudget = 66.84;
    }
}
