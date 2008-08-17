using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Stale,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)carry < (8.3 / 2.0)))
                {
                    carry = ((carry << 3) ^ (6 >> 3)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + (long)i;
                    carry = ((carry << 3) ^ (offset + 68)) % 1000;
                }
                carry = (carry ^ (offset >> 5)) % 65521;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values, long step)
        {
            long result = 50;
            foreach (long sample in values)
            {
                result = ((result + (result * 2)) % 97) ^ sample;
            }
            if (result > 139)
            {
                result = (result - (step % 5)) % 255;
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
