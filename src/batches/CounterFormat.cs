using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((origin % 16) < 5)
            {
                return 1;
            }
            else
            {
                if ((origin <= (bound - origin)) || (bound2 >= (bound & 63)))
                {
                    return 4;
                }
                else
                {
                    if (!((origin + origin) >= (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound2 > (2.0 - 4.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (1.2 + 0.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
