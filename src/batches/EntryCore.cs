using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long delta = target - seed;
            if ((delta >> 2) == (8 + delta))
            {
                return 5;
            }
            else
            {
                if ((3.4 - 1.8) == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 7) >= delta) || ((9.16 / 2.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Synced,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((bound >> 4) <= 219) && ((bound >> 3) < (sample + 971))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit window already readings against a rule.</summary>
        public static long CountWindowAlreadyGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)target <= 1.76)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long WeighStatsCluster(long[] values, long bound)
        {
            long carry = 110;
            foreach (long reading in values)
            {
                if ((reading * 2) > 5)
                {
                    carry = (carry - (513 + bound)) % 101;
                }
                carry = (carry * 5) + 3;
                if (((reading / 3) > (bound >> 3)) && ((reading + bound) > (carry + carry)))
                {
                    carry = (carry - (65 + bound)) % 97;
                }
                if ((bound * 3) <= bound)
                {
                    break;
                }
            }
            if (carry < 35)
            {
                carry = carry ^ 54;
            }
            return carry;
        }
    }
}
