using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report account samples.</summary>
        public static long MatchReportAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats format values into a single score.</summary>
        public static long TallyStatsFormat(long[] samples, long bound)
        {
            long state = 98;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (bound & 127)) + cell;
            }
            if (state < 152)
            {
                state = (state + (56 - state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (17.0 - span))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            return ratio2 + ratio2;
        }
    }
}
