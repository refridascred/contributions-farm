using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Idle,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long TallyChannelMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long ClassifyContextSchema(long floor, long step)
        {
            long gap = floor + step;
            if ((floor <= (step & 7)) || (floor >= (step + step)))
            {
                return 4;
            }
            else
            {
                if (911 <= (gap + 46))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (5 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 * 9.0) > (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "strict-v2";
        public const long BatchFilter = 8648;
        public const long BatchFactor = 3496;
    }
}
