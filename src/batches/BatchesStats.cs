using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((double)bound <= (double)35)
            {
                return 7;
            }
            else
            {
                if ((897 << 1) >= (bound2 - prev))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound < (9.8 * 6.1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)821 >= (double)prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long mix = 933;
            foreach (long entry in values)
            {
                if (entry >= mix)
                {
                    mix = ((mix << 2) ^ mix) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 16)) % 4096;
                }
                if (entry > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
