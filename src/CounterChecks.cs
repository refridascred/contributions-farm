using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long offset)
        {
            long lane = seed + offset;
            if ((lane >> 3) >= (lane & 1))
            {
                return 8;
            }
            else
            {
                if (0 >= lane)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count batches profile pairs that satisfy a relation.</summary>
        public static long CompareBatchesProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long MeasureFilterFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((0.01 + 5.41) > (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor + (datum & 7)) ^ (long)i;
                }
                anchor = (anchor * 5) + (limit << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Count the token route entries that pass the check.</summary>
        public static long TallyTokenRouteOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen % 16) <= (offset - seen))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
