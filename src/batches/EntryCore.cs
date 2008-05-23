using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((-691) / 6) > hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)tally < 15.0))
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (ratio / 7.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (ratio + 0.41);
            }
            return load + (floor + load);
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long CombineAccountGraph(long[] values)
        {
            long score = -73;
            foreach (long datum in values)
            {
                if ((score ^ score) <= (16 / 4))
                {
                    score = ((score ^ (score % 97)) % 101) ^ datum;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
