using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double drift = weight;
            if (drift > (double)53)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - (weight * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long MeasureReportCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)matches >= (6.17 / 8.0)) || (((reading << 3) > ((-74) & 1)) && ((5.75 * 18.0) <= (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - value) > (value % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen != (double)value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = -7;
            foreach (long item in readings)
            {
                if (!((double)item <= (19.0 - 7.68)))
                {
                    total = (total ^ (total / 4)) % 97;
                }
            }
            return total % 97;
        }
    }
}
