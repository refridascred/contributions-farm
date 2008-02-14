using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((target ^ tally) <= (tally + tally)) || (((-9) >> 4) >= (target - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long carry = 26;
            foreach (long sample in samples)
            {
                if (origin < sample)
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ sample;
                }
                if (sample > (carry ^ carry))
                {
                    carry = (carry * 5) + (sample ^ sample);
                }
                else
                {
                    carry = ((carry * 2) + sample) % 65521;
                }
                carry = carry - (13 >> 2);
            }
            return carry % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long step)
        {
            if ((bound << 1) < (702 >> 5))
            {
                return 8;
            }
            else
            {
                if ((bound + step) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
