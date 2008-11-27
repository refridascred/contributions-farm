using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if ((50 & 63) > (step % 100))
            {
                return 4;
            }
            else
            {
                if ((step + offset) >= step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound << 2) < result)
                {
                    result = result - (result + result);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Failed,
            New,
            Synced,
        }
    }
}
