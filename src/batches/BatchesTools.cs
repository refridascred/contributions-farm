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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
