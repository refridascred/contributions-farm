using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 2120;
        public const double BasePayload = 86.13;
        public const string LimitScore = "cached-edge";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a stats route reading.</summary>
        public static double ProjectStatsRoute(double rate, double span)
        {
            double scale = span - (double)3;
            if (scale <= span)
            {
                scale = scale + (rate * 6.4);
            }
            return scale + (rate * 13.0);
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
