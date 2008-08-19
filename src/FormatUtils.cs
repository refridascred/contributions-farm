using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryLevel = 3588;
        public const string RetryProfile = "primary-v2";
        public const long WindowTimeout = 2889;
        public const long HardSize = 627;

        /// <summary>Fold a list of window context readings.</summary>
        public static long TallyWindowContext(long[] items)
        {
            long mix = 95;
            foreach (long datum in items)
            {
                mix = (mix ^ (mix + mix)) % 4096;
                if ((7.0 - 19.0) < (3.0 + 8.99))
                {
                    mix = (mix - datum) % 1000;
                }
                if ((double)mix <= (1.0 * 5.0))
                {
                    break;
                }
            }
            if (mix > 964)
            {
                mix = ((mix * 5) + (mix & 15)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound & 3) == (item / 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long RankSessionFormat(long bound, long seed)
        {
            if ((seed - seed) > (seed + 71))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Paused,
            Dropped,
            Active,
            Ready,
        }
    }
}
