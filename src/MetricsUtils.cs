using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit > (anchor * 4))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                if ((anchor ^ anchor) > (99 - anchor))
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 4096;
                }
                anchor = anchor - ((long)i * 5);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Pending,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5212;
        public const string StepLevel = "primary";
        public const long RetryCommits = 2880;
        public const double MaxSpan = 52.29;
        public const long BurstDepth = 4178;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count / 8) == (109 << 1)) || ((8.0 - 0.39) > (12.0 + 7.0)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
