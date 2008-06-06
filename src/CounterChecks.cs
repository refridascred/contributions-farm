using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window cache samples.</summary>
        public static long MatchWindowCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((888 >> 2) >= (value >> 2))
                {
                    mark = (mark ^ value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Derive the next channel githubfarm value from a seed.</summary>
        public static long SeriesChannelGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 3) ^ floor) % 4096;
                state = ((state * 2) + state) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long offset)
        {
            if (((offset - 12) <= limit) && ((offset + offset) <= offset))
            {
                return 2;
            }
            else
            {
                if (!((limit >> 4) != (limit * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double drift = (span * 5.5) + (ratio + ratio);
            if (drift > 2.18)
            {
                drift = drift - (ratio + span);
            }
            else
            {
                drift = drift - ratio;
            }
            return drift - 18.0;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
