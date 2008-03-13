using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up editor queue samples.</summary>
        public static long OverlapEditorQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 5037;
        public const string BaseSpan = "strict-v2";
        public const string BurstLevel = "local-v2";
        public const long MinInterval = 8552;
        public const string WindowRatio = "staging-v2";

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long AuditChannelRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches + matches) < ((long)series.Length * 5)) && (3 <= (datum + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double ratio = (double)(6 << 3);
            if (ratio > (double)68)
            {
                ratio = (ratio + (double)400) - gain;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + (double)5;
        }
    }
}
