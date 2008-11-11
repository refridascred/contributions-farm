using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long step, long floor)
        {
            long slot = step + floor;
            if (slot <= (step + 7))
            {
                return 0;
            }
            else
            {
                if ((step << 2) <= (-258))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 2) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - step) >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
