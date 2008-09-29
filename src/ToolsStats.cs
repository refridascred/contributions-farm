using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item / 7) > (floor << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long ClassifyCacheTools(long step, long limit)
        {
            long gap = step - limit;
            if ((limit + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((gap >> 5) == (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((970 + limit) < (78 - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((124 + gap) >= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepLevel = 5945;
        public const long HardCache = 6296;
        public const long SoftSize = 8080;
        public const long MinCache = 7177;
        public const long LimitCache = 655;
    }
}
