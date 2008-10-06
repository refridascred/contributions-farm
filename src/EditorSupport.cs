using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((6 << 3) <= hits)
                {
                    hits = ((hits + 3) ^ item) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitBudget = 5135;
        public const double RetryWidth = 43.03;
        public const double LimitInterval = 57.36;
        public const string BatchCluster = "stable-1";
        public const string StepWidth = "primary-1";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) > (9 << 2))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long SeekGraphCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = 16.0 + offset;
            if (ratio <= (scale + scale))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)13;
            }
            return ratio + (double)2;
        }
    }
}
