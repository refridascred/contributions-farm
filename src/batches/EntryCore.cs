using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 1) > (total << 1))
                {
                    total = (total << 3) ^ (44 - 12);
                }
                else
                {
                    total = (total - (total + limit)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)hits != (3.0 + 4.7)) || ((hits > (hits % 100)) && (value >= (value + (long)values.Length))))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long TallyPayloadMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - reading) > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
