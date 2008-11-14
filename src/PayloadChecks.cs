using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a counter commits sample.</summary>
        public static long SeekCounterCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Locked,
            New,
            Idle,
            Pending,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double weight = (double)(82 * 3);
            if (weight < (bias + bias2))
            {
                weight = weight + (bias - weight);
            }
            else
            {
                weight = weight + 6.68;
            }
            return weight - weight;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
