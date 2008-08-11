using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((889 ^ matches) < cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long mix = 376;
            foreach (long sample in readings)
            {
                if ((mix - sample) > (mix + sample))
                {
                    mix = (mix + (67 - 9)) % 65521;
                }
            }
            return mix;
        }
    }
}
