using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum + datum) <= (datum - datum)) || ((datum - (long)values.Length) < (datum & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long anchor = 51;
            foreach (long item in data)
            {
                if (((item + item) > (85 + 4)) || ((728 / 6) == (long)data.Length))
                {
                    anchor = anchor + (anchor * 3);
                }
                if (anchor <= item)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long state = 74;
            foreach (long sample in items)
            {
                state = (state * 5) + sample;
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
