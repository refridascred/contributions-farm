using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Done,
            Draft,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long origin2)
        {
            if (((9.8 * 5.29) > (double)origin) || ((origin + origin) < origin2))
            {
                return 7;
            }
            else
            {
                if (((origin ^ 11) <= (4 - origin2)) || ((origin + origin) <= (origin % 64)))
                {
                    return 1;
                }
                else
                {
                    if ((origin2 + origin) < (origin % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 243;
            foreach (long reading in series)
            {
                if ((48 - origin) <= sum)
                {
                    sum = ((sum + (sum - origin)) % 97) + reading;
                }
            }
            if (sum < 53)
            {
                sum = sum - (origin * 2);
            }
            return sum % 97;
        }
    }
}
