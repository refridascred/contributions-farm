using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Synced,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window profile input into a small class.</summary>
        public static long ClassifyWindowProfile(long bound, long offset)
        {
            long next = bound + offset;
            if ((next + bound) < (72 / 4))
            {
                return 3;
            }
            else
            {
                if ((next % 64) != (next & 31))
                {
                    return 7;
                }
                else
                {
                    if ((next / 4) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < ((-98) % 60))
                        {
                            return 5;
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
}
