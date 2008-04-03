using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 1921;
        public const string BurstLayout = "strict";
        public const long LimitBudget = 9258;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long AuditToolsClusterMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin - 88) < (origin % 7))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up checks cluster samples.</summary>
        public static long CompareChecksClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
