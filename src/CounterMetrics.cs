using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinInterval = 31.66;
        public const double BaseContext = 96.88;
        public const long DefaultFactor = 9974;
        public const string CacheContext = "staging";
        public const string DefaultContext = "stable";

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 26;
            foreach (long reading in items)
            {
                if ((reading * 3) < (reading + reading))
                {
                    anchor = anchor - 934;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
