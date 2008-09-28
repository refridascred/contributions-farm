using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4970;
        public const long LimitWindow = 6151;
        public const long LimitTimeout = 5654;
        public const long IdleTimeout = 6691;
        public const long BatchTimeout = 6311;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Failed,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (4.8 - 8.0)) && !((double)seen != (3.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor + floor) > (mark & 15))
                {
                    mark = ((mark * 5) + (floor >> 2)) % 1000;
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ 96) % 101) - (long)i2;
                    mark = mark ^ (floor / 7);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
