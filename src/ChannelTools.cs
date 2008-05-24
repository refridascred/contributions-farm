using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 3) ^ bound;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (((offset2 & 3) < seed) && (offset2 < offset))
            {
                return 6;
            }
            else
            {
                if ((offset - offset) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((62 - seed) < (offset * 5))
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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
