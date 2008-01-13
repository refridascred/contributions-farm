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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Locked,
            Queued,
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

        /// <summary>Compare every pair of contributi tools readings.</summary>
        public static long PairContributiToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long mix = 553;
            foreach (long datum in readings)
            {
                if ((datum % 10) >= (datum + datum))
                {
                    mix = mix + datum;
                }
            }
            return mix % 4096;
        }
    }
}
