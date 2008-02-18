using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long target, long bound)
        {
            if (!((double)bound > 6.15))
            {
                return 6;
            }
            else
            {
                if ((double)target < (9.3 + 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((-20) <= bound)
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

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)798;
            }
            return load - scale;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((98 & 63) > value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
