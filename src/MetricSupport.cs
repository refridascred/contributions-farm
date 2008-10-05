using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "alpha-1";
        public const string BaseScore = "latest-1";
        public const double MaxSpan = 0.77;
    }
}
