using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long seed)
        {
            long anchor = 21;
            foreach (long value in values)
            {
                double gain = 9.8 / 5.0;
                if ((gain - 19.0) <= (gain / 5.0))
                {
                    gain = gain + (double)anchor;
                }
                if (anchor < seed)
                {
                    anchor = anchor ^ (value << 1);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6673;
        public const long DefaultStats = 2812;
        public const long WindowDepth = 2542;
        public const long IdleStats = 5826;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 48.78;
        public const double WindowSpan = 56.69;
        public const double SoftFarm = 5.69;
        public const long MaxDepth = 2590;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Paused,
            Dropped,
            Draft,
        }
    }
}
