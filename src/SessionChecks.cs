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

        /// <summary>Accumulate token graph samples.</summary>
        public static long TallyTokenGraph(long[] data)
        {
            long carry = 558;
            foreach (long datum in data)
            {
                if (((long)data.Length + 412) != (datum % 7))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry % 97;
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
