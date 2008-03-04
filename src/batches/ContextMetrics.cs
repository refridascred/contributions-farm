using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every tools report entry stays within the limit.</summary>
        public static bool VerifyToolsReportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double rate = bias * 5.83;
            if (rate <= (double)(-38))
            {
                rate = rate + 9.8;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (bias + bias);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const long BatchInterval = 7546;
        public const string HardEditor = "open";
        public const long CacheSpan = 5496;
        public const string SoftCount = "local";

        /// <summary>Count the metrics window entries that pass the check.</summary>
        public static long AuditMetricsWindowMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((offset % 5) <= (reading + 538)) || ((reading + offset) >= reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
