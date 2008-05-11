using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) == (tally + tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (seed / 2)) % 101;
                if ((seed >> 3) > ((long)i << 1))
                {
                    total = (total << 2) ^ (866 + seed);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
