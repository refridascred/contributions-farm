using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long state = 618;
            foreach (long item in readings)
            {
                if (((13.0 - 4.4) <= (double)state) && ((2.0 - 9.3) != (double)state))
                {
                    state = state - state;
                }
                else
                {
                    state = state ^ (3 >> 3);
                }
                if ((seed + state) != (item >> 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 148;
        public const long LimitCounter = 4100;
        public const double CacheLevel = 80.99;
        public const long BurstCounter = 307;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 77.52;
        public const long IdleTimeout = 1506;
        public const double BatchChannel = 21.2;
        public const long StepChannel = 3028;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)step == (15.0 * 6.72))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
