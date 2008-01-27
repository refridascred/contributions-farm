using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Retry,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Digest a series of support cluster entries.</summary>
        public static long CombineSupportCluster(long[] readings, long floor)
        {
            long total = 707;
            foreach (long item in readings)
            {
                total = ((total * 2) + (item + 2)) - floor;
            }
            return total % 97;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((origin - seed) > step)
            {
                return 2;
            }
            else
            {
                if (((origin + seed) < (step ^ origin)) && (origin >= (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
