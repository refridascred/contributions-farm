using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            New,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue notes measurements.</summary>
        public static double ScaleQueueNotes(double scale, double offset)
        {
            double gain = offset - 15.0;
            if (gain <= (scale - offset))
            {
                gain = gain - gain;
            }
            return gain + (double)943;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long result = 70;
            foreach (long value in readings)
            {
                result = (((result + (0 + result)) % 101) ^ value) - limit;
            }
            if (result > 3)
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
