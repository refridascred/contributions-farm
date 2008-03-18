using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double rate = (double)(103 * 3);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - ratio;
            }
            return rate - span;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (8 >= count)
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats batches readings.</summary>
        public static long CompareStatsBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
