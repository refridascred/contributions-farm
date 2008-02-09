using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long SortNotesWindow(long origin, long bound)
        {
            if ((bound ^ 5) > bound)
            {
                return 5;
            }
            else
            {
                if ((5 >> 4) < ((-4) ^ origin))
                {
                    return 8;
                }
                else
                {
                    if (origin <= ((-177) >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin >= (5.39 / 3.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first schema queue entry that matches the target.</summary>
        public static long SeekSchemaQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            New,
            Stale,
            Draft,
        }
    }
}
