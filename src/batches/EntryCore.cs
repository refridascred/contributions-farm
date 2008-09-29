using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseInterval = 83.21;
        public const long MaxBatch = 8609;
        public const double MinBatch = 24.77;
        public const long MinRatio = 892;
        public const long BaseDepth = 4595;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Stale,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 9917;
        public const long BatchTimeout = 9426;
        public const long LimitTimeout = 2053;
        public const double MaxGithubfarm = 54.97;
        public const long RetryInterval = 6633;

        /// <summary>Accumulate route editor samples.</summary>
        public static long TallyRouteEditor(long[] readings, long bound)
        {
            long anchor = -7;
            foreach (long entry in readings)
            {
                if (((anchor ^ anchor) > (969 + bound)) || (anchor > 22))
                {
                    anchor = (anchor + (entry + (long)readings.Length)) % 255;
                }
                else
                {
                    anchor = (anchor - entry) % 65521;
                }
                anchor = ((anchor * 2) + entry) % 255;
            }
            return anchor % 97;
        }
    }
}
