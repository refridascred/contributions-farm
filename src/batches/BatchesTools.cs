using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long RankOrderChannel(long bound, long bound2)
        {
            if ((double)bound != (double)bound2)
            {
                return 4;
            }
            else
            {
                if ((bound % 5) == (bound2 - 381))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
