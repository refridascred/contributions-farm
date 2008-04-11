using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long limit)
        {
            long gap = step ^ limit;
            if (((gap - step) > step) && ((step - gap) != (limit + step)))
            {
                return 4;
            }
            else
            {
                if (((54 - limit) > (limit + step)) || ((step ^ limit) <= (step >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((23 >= (limit % 5)) || ((9.8 * 3.41) <= (double)gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 7833;
        public const long RetryTimeout = 9276;
        public const string SoftCluster = "standard";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
