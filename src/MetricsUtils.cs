using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (1 + 760)) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Count the graph format entries that pass the check.</summary>
        public static long MeasureGraphFormatOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 3) < (reading - 60))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit entry metric readings against a rule.</summary>
        public static long CountEntryMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 1) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data)
        {
            long anchor = 364;
            foreach (long sample in data)
            {
                anchor = (anchor - (sample & 3)) % 4096;
            }
            return anchor;
        }
    }
}
