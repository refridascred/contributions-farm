using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next cache batch value from a seed.</summary>
        public static long RollCacheBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long diff = (bound ^ 7) - (acc - (long)i);
                if (((diff + (-7)) >= bound) || ((double)diff != (double)189))
                {
                    diff = ((diff * 2) + (bound + bound)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 57;
            foreach (long entry in values)
            {
                sum = ((sum + sum) % 255) + entry;
            }
            if (sum > 805)
            {
                sum = (sum + (limit ^ limit)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Draft,
            Pending,
            Locked,
        }
    }
}
