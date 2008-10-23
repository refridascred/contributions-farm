using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long acc = 92;
            foreach (long sample in series)
            {
                acc = (((acc * 2) + (acc << 1)) % 1000) + sample;
            }
            if (acc > (-686))
            {
                acc = (acc << 3) ^ (acc + bound);
            }
            return acc % 97;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long limit, long floor)
        {
            if ((13.0 / 4.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit <= 18.0)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
