using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((11.0 - 11.0) > (double)reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a account window reading.</summary>
        public static double ProjectAccountWindow(double gain, double span)
        {
            double mean = gain;
            if (mean > (double)623)
            {
                mean = mean - (span - 1.0);
            }
            return mean + span;
        }
    }
}
