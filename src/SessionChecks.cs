using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Stale,
            Failed,
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool VerifyFormatFarmLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitDepth = 58.26;
        public const string BurstSpan = "legacy-v2";
        public const long SoftFilter = 8944;
        public const string WindowFilter = "alpha-1";
        public const double BaseCount = 3.78;

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long TallyCommandNotesHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)810 >= (double)bound)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
