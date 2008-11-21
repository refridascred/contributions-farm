using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long bound)
        {
            long diff = target - bound;
            if ((double)target > (9.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if (diff >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target > (4.3 - 2.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every channel batch entry stays within the limit.</summary>
        public static bool GuardChannelBatchRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)seed == (1.9 * 6.9))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 13.43;
        public const double IdleRatio = 72.49;
        public const string MaxCommand = "open";
        public const long StepTimeout = 6754;
        public const double BatchSize = 86.28;
    }
}
