using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Ready,
            New,
            Pending,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Active,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long floor2)
        {
            if ((floor >> 5) <= (floor2 % 24))
            {
                return 6;
            }
            else
            {
                if ((20.0 + 16.0) >= (double)floor2)
                {
                    return 2;
                }
                else
                {
                    if (!((13.0 / 5.0) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((4.04 * 6.0) == (double)floor) && ((double)floor < 4.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
