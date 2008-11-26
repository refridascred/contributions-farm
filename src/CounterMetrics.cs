using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long target)
        {
            if ((step % 97) < (step - 30))
            {
                return 3;
            }
            else
            {
                if (!((double)step <= (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (((target + step) >= step) && (4 > (target * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
