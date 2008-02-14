using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long seed)
        {
            if (19.0 >= (double)seed)
            {
                return 6;
            }
            else
            {
                if (2.03 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step & 15) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
