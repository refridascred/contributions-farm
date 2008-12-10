using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Measure how many payload order samples are out of range.</summary>
        public static long CountPayloadOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - 919) >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a report batches pair into a bucket.</summary>
        public static long GradeReportBatches(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((floor + (-98)) <= (diff * 3)))
            {
                return 4;
            }
            else
            {
                if (offset < (diff - floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= (5.0 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
