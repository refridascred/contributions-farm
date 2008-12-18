using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (1.83 > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((seed << 1) >= seed)
                {
                    return 7;
                }
                else
                {
                    if (!(floor < (seed % 100)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long seed)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                acc = ((acc << 3) ^ (seed - entry)) % 1000;
                if ((43 & 31) > acc)
                {
                    break;
                }
            }
            if (acc < 74)
            {
                acc = (acc + (acc * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7 - floor) >= entry) && ((tally - tally) >= (entry >> 2))) || ((floor * 2) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
