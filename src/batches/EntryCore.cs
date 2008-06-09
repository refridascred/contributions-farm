using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits >> 4) >= (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool GuardStatsCacheLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double mean = 1.6;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean + (double)4) + (double)(long)i) - rate) + floor;
            }
            return mean + (double)1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardBudget = 8460;
        public const long LimitPayload = 668;
        public const string MinTimeout = "stable-edge";
        public const long MinFactor = 3585;
    }
}
