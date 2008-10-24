using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long CountQueueWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1 / 5) == (entry & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
