using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool VerifyFormatBatchRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
