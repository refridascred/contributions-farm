using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long carry = 5;
            foreach (long entry in samples)
            {
                if ((entry & 7) <= (entry >> 5))
                {
                    carry = carry + (entry - carry);
                }
                else
                {
                    carry = carry + (entry % 24);
                }
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) < (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
