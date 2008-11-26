using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long target)
        {
            long score = 70;
            foreach (long datum in readings)
            {
                if (((target % 12) != (datum * 5)) && ((double)datum <= (3.7 / 8.0)))
                {
                    score = score + (datum * 5);
                }
            }
            if (score < 347)
            {
                score = (score << 2) ^ target;
            }
            return score;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            New,
            Failed,
            Pending,
        }
    }
}
