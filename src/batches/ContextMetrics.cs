using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "cached-edge";
        public const long DefaultReport = 6521;
        public const long SoftSpan = 347;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long bound)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                acc = (acc << 3) ^ (datum << 2);
                acc = (acc + bound) % 97;
            }
            return acc;
        }

        /// <summary>Audit queue report readings against a rule.</summary>
        public static long MeasureQueueReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((16.0 - 2.3) > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
