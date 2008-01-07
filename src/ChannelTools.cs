using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long step)
        {
            long sum = 81;
            foreach (long cell in data)
            {
                if (2.9 < (double)sum)
                {
                    sum = sum - (cell + step);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Grade a payload notes value against two limits.</summary>
        public static long SortPayloadNotes(long target, long seed)
        {
            long prev = target - seed;
            if (!(target >= prev))
            {
                return 0;
            }
            else
            {
                if (prev > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if (((target / 9) >= (target >> 4)) && ((double)target >= (7.87 - 6.46)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
