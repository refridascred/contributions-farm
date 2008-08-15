using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            if ((double)origin != (1.64 - 3.4))
            {
                return 0;
            }
            else
            {
                if (!((origin >> 3) == (limit / 7)))
                {
                    return 8;
                }
                else
                {
                    if (((origin - limit) == (origin - origin)) || ((origin << 2) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long bound)
        {
            long anchor = 51;
            foreach (long sample in series)
            {
                anchor = (anchor << 3) ^ (bound + sample);
            }
            return anchor;
        }
    }
}
