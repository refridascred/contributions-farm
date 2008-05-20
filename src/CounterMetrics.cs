using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((0 + 231) >= (bound2 >> 2))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 5) == (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if ((25 / 2) == (floor + 749))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound2 <= (bound ^ bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate batches stats readings against a bound.</summary>
        public static bool VerifyBatchesStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
