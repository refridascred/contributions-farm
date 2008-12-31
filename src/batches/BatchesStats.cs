using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long bound, long target)
        {
            long step = bound + target;
            if (bound > (step ^ bound))
            {
                return 0;
            }
            else
            {
                if ((double)step >= (8.52 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if (target >= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Project the next context schema value.</summary>
        public static double ScaleContextSchema(double scale, double span)
        {
            double mean = 15.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - scale) + span;
            }
            return mean - 1.5;
        }
    }
}
