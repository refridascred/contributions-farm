using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.8 - 0.63) >= (double)bound)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long seed)
        {
            if ((step + seed) == (seed / 3))
            {
                return 7;
            }
            else
            {
                if ((step & 7) < step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (target & 31)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((3.7 * 10.0) != (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long TotalMetricsContributi(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((item << 2) <= (mix + item))
                {
                    long tally = (item * 5) + (item & 15);
                    mix = (mix ^ (mix + tally)) % 255;
                    break;
                }
                if ((0.55 * 5.73) > (double)item)
                {
                    mix = (mix - (90 + item)) % 97;
                }
            }
            return mix % 97;
        }
    }
}
