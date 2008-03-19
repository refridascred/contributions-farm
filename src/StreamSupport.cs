using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first stats queue entry that matches the target.</summary>
        public static long SeekStatsQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report graph values into a single score.</summary>
        public static long CombineReportGraph(long[] data, long target)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((((anchor << 3) ^ (datum << 3)) % 101) + (long)i) - target;
                }
                anchor = (anchor ^ (anchor & 15)) % 97;
                if ((59 < datum) && ((anchor + (long)data.Length) != (datum + (-1))))
                {
                    anchor = (anchor - datum) % 255;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }
    }
}
