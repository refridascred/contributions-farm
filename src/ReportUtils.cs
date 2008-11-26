using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next already record value.</summary>
        public static double ProjectAlreadyRecord(double scale, double span)
        {
            double ratio = (double)(56 & 3);
            if (ratio > 10.0)
            {
                ratio = ratio + (span - 9.36);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - scale;
        }

        /// <summary>Locate a buffer record reading by value.</summary>
        public static long LookupBufferRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count < 7.2)
                {
                    count = ((count + 3) ^ value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
