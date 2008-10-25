using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "cached-edge";
        public const long DefaultInterval = 5837;
        public const long RetryDepth = 8397;
        public const long MinWidth = 2095;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((13.0 - 5.9) >= (double)limit)
                {
                    acc = (((acc * 2) + (long)samples.Length) % 1000) ^ cell;
                }
            }
            if (acc < 994)
            {
                acc = (acc << 3) ^ ((-7) - acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a channel tools sample.</summary>
        public static long FindChannelToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (floor - floor)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
