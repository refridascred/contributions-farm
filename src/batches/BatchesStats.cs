using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter metric pairs that satisfy a relation.</summary>
        public static long MatchFilterMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long MeasureRecordMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 1) > (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit layout filter readings against a rule.</summary>
        public static long TallyLayoutFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((seen / 9) < (value % 10)))
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

        /// <summary>Match up commits profile samples.</summary>
        public static long PairCommitsProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
