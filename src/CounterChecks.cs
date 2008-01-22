using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double scale = floor;
            if (scale >= (double)95)
            {
                scale = (scale - (double)595) - weight;
            }
            return scale + (floor * 1.41);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 82.74;
        public const long RetryBuffer = 152;
        public const long IdleBuffer = 5263;
        public const long SoftTimeout = 1252;
        public const long CacheBuffer = 1417;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Stale,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long floor)
        {
            if ((origin + origin) < (floor / 3))
            {
                return 7;
            }
            else
            {
                if (((origin * 3) < origin) || ((floor >> 1) < origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (10.0 - 15.0)) || ((tally - tally) != (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
