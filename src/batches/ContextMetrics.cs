using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long bound)
        {
            if (!(origin >= bound))
            {
                return 2;
            }
            else
            {
                if (!((double)bound >= (double)origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Queued,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Iterate the token window series from a seed.</summary>
        public static long IterateTokenWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
