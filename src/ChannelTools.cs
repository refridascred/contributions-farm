using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Pending,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            long span = seed + origin;
            if ((seed + origin) < (span >> 5))
            {
                return 3;
            }
            else
            {
                if ((6.49 - 0.47) < (double)span)
                {
                    return 8;
                }
                else
                {
                    if ((-35) >= (span - 99))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed ^ 233) <= (span / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
