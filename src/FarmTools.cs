using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long MeasureChannelLayoutOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((3.0 * 8.16) != (double)seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
