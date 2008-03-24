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

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "primary-1";
        public const double DefaultPayload = 19.45;
        public const long MaxPayload = 1294;
        public const long SoftPayload = 4978;
        public const double BasePayload = 87.77;
    }
}
