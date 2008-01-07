using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
