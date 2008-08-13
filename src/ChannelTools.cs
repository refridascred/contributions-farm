using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 + 4.9) != (double)cell)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LocateChecksStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
