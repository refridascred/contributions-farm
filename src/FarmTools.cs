using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = 10.0 / 9.0;
            if (bias2 >= (bias2 * 3.75))
            {
                bias2 = bias2 + (bias2 + scale);
            }
            return bias2 - (bias * 13.0);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long bound = offset - target;
            if ((target / 2) <= (893 ^ bound))
            {
                return 2;
            }
            else
            {
                if (1.0 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
