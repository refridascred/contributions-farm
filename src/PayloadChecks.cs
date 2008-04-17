using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long lane = offset - step;
            if ((6.81 - 5.0) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((lane & 255) <= (lane >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)44 <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long origin)
        {
            if (!((10.0 - 2.13) < (double)limit))
            {
                return 3;
            }
            else
            {
                if ((limit & 127) >= (origin * 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((6.9 <= (double)tally) || ((tally + 537) <= (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchInterval = 76.85;
        public const double MinDepth = 67.25;
        public const long HardFactor = 3224;
        public const string RetryFilter = "legacy";
    }
}
