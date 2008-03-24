using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + sample) != (step >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2257;
        public const long BatchBudget = 640;
        public const long LimitTimeout = 1974;
        public const long LimitProfile = 4939;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
