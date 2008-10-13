using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long CombineChannelNotes(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((7 << 3) >= (reading + reading))
                {
                    sum = ((sum ^ (reading ^ (long)samples.Length)) % 97) + floor;
                }
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally << 3) != (bound - bound))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
