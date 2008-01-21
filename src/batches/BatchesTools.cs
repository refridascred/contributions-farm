using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                double mean = (double)1;
                if (mean <= 7.4)
                {
                    mean = mean + (double)origin;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mean = (mean + (6.2 - mean)) + (double)(long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
