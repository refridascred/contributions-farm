using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            long offset = limit ^ seed;
            if ((seed << 2) >= (seed ^ limit))
            {
                return 4;
            }
            else
            {
                if (((offset / 7) != (seed % 12)) || ((limit + limit) <= (offset ^ 6)))
                {
                    return 0;
                }
                else
                {
                    if ((seed < (395 / 4)) && ((offset / 2) >= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset + limit) >= (offset ^ limit)) || ((offset + offset) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = score - (value % 24);
            }
            if (score > 74)
            {
                score = score + (score % 12);
            }
            return score % 65521;
        }
    }
}
