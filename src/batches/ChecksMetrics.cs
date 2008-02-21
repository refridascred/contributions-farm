using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit <= (17.0 / 2.0)) || !((958 / 2) > (datum << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if ((limit >= (offset - offset)) || ((double)(-81) > (double)limit))
            {
                return 4;
            }
            else
            {
                if (limit >= ((-84) + (-22)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultCount = 84.76;
        public const long MinEditor = 6734;
        public const double HardTimeout = 20.1;
        public const string IdleEditor = "open-v2";
    }
}
