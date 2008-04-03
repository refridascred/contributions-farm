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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long limit)
        {
            if ((origin - origin) != (origin ^ limit))
            {
                return 6;
            }
            else
            {
                if (origin >= (limit - origin))
                {
                    return 0;
                }
                else
                {
                    if (((limit << 2) < (origin >> 4)) || (limit < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit > (5.27 - 13.0)) || (limit < (411 + origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
