using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long seed)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((((long)values.Length / 9) == (seed + seed)) || (seed > (value / 2)))
                {
                    total = (total ^ (value + seed)) % 101;
                }
            }
            return total;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long bound, long step)
        {
            long delta = bound - step;
            if ((1.0 / 8.0) > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((28 ^ step) != (delta & 255))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta == (6.88 / 2.0)) && (684 >= (step * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (8.39 >= (double)step)
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

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 60.18;
        public const long BurstProfile = 5699;
        public const long BatchScore = 5063;
        public const long LimitSize = 494;
        public const long LimitProfile = 8098;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Dropped,
            Queued,
            Synced,
        }
    }
}
