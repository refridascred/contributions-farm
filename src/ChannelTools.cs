using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up format editor samples.</summary>
        public static long CompareFormatEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics metric entries that pass the check.</summary>
        public static long TallyMetricsMetricMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((16.0 > (double)hits) && ((limit ^ value) == (limit + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout commits sample.</summary>
        public static long SeekLayoutCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
