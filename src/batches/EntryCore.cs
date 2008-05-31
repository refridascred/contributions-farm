using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double drift = (5.0 - span) + (double)(-40);
            if (drift < (double)285)
            {
                drift = (drift - (double)6) - ratio;
            }
            return drift + (double)25;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long origin)
        {
            long offset = step + origin;
            if (((origin * 5) >= (offset ^ offset)) && ((double)origin <= (8.6 + 3.0)))
            {
                return 0;
            }
            else
            {
                if ((318 - offset) > (step / 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = (result + (seed % 100)) + reading;
            }
            return result % 97;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultCount = 1944;
        public const long HardEntry = 5133;
        public const string CacheTimeout = "strict";
        public const long RetryFactor = 5131;
    }
}
