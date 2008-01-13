using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (889 >= (tally - 8))
                {
                    tally = ((tally + 1) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi metrics readings.</summary>
        public static long TotalContributiMetrics(long[] items)
        {
            long mark = 81;
            foreach (long item in items)
            {
                mark = ((mark << 2) ^ (21 ^ item)) % 255;
            }
            if (mark < 69)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Paused,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Find the first metrics commits entry that matches the target.</summary>
        public static long SeekMetricsCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
