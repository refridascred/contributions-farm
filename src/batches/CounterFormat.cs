using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count commits channel pairs that satisfy a relation.</summary>
        public static long MatchCommitsChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
