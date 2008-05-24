using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long origin)
        {
            if (origin >= (origin + bound))
            {
                return 6;
            }
            else
            {
                if ((72 % 10) >= bound)
                {
                    return 7;
                }
                else
                {
                    if (!((origin * 5) > (-72)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ ((long)i >> 5)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
