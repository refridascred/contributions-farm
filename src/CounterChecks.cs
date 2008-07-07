using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long mark = 183;
            foreach (long value in readings)
            {
                mark = (mark ^ (value >> 3)) % 101;
                if ((value / 9) < mark)
                {
                    mark = mark - (value * 3);
                }
                else
                {
                    mark = (mark - ((long)readings.Length ^ value)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long MeasureClusterBatchesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (floor <= (18 % 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
