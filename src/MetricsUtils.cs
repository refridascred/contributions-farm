using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batches farm pair into a bucket.</summary>
        public static long SortBatchesFarm(long target, long offset)
        {
            long edge = target ^ offset;
            if ((double)edge != (6.1 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((offset / 9) <= (298 + edge))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (6.8 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long CompareChannelBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double gain = offset / 5.0;
            if (gain < gain)
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)69) - (double)(long)i;
            }
            return gain + (offset - ratio);
        }
    }
}
