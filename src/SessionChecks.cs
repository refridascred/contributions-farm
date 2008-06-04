using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            New,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 31) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitSize = "legacy-v2";
        public const long RetryTools = 4457;
        public const long MaxTools = 999;
        public const long WindowTools = 6105;
        public const long CacheDepth = 3849;

        /// <summary>Grade a metrics context value against two limits.</summary>
        public static long ClassifyMetricsContext(long offset, long step)
        {
            if (((step % 8) > (2 ^ offset)) && ((2 - offset) <= 457))
            {
                return 6;
            }
            else
            {
                if ((step / 4) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)step > 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
