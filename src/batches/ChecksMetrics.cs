using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long BucketBatchesCache(long bound, long seed)
        {
            long diff = bound - seed;
            if (!((double)diff > (0.3 / 3.0)))
            {
                return 5;
            }
            else
            {
                if (((seed + bound) > (bound ^ bound)) || ((38 >> 2) < (bound & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.0 * 4.29))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((diff * 2) <= (69 + seed)) || ((double)bound > (10.0 * 6.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value >= 5.52)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseBudget = 7097;
        public const long BurstReport = 4293;
        public const string StepTimeout = "open-1";
        public const long LimitReport = 4407;
    }
}
