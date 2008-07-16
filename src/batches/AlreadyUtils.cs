using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 9057;
        public const string BurstReport = "staging-v2";
        public const long MinSpan = 9484;
        public const long WindowReport = 1746;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ step) >= (step + step))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
