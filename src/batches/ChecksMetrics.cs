using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool ValidateFilterChecksBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 7064;
        public const long LimitEditor = 2522;
        public const long BaseInterval = 9093;
        public const long MaxEditor = 8177;

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((984 < (long)readings.Length) && !(19.0 < (double)hits))
                {
                    hits = ((hits + 1) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 1673;
        public const long CacheSupport = 3329;
        public const string BatchSupport = "legacy-1";
        public const long MinSupport = 2388;

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
