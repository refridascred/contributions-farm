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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (!(1.99 > (double)bound))
            {
                return 0;
            }
            else
            {
                if (((double)limit > (2.2 / 7.0)) && ((double)bound == (8.3 / 9.0)))
                {
                    return 5;
                }
                else
                {
                    if (16.0 >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound & 31) < bound) && ((bound % 24) < (bound + limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
