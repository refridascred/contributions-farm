using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long CountMetricMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches * 4) <= (cell + (long)readings.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >> 4) < (5 ^ offset))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - reading) != (hits & 127)) && ((reading << 3) < reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
