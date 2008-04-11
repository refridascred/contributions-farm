using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 1731;
        public const double LimitWidth = 79.84;
        public const long LimitStats = 450;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 2) ^ ((long)i + 837);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
