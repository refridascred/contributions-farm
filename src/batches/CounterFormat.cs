using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batch layout input into a small class.</summary>
        public static long SortBatchLayout(long origin, long limit)
        {
            long next = origin ^ limit;
            if (!((95 + limit) >= (origin ^ origin)))
            {
                return 6;
            }
            else
            {
                if (!(limit > origin))
                {
                    return 0;
                }
                else
                {
                    if (((40 / 4) <= origin) && ((origin + origin) != (origin - next)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ limit) >= (next << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = 933;
            foreach (long sample in samples)
            {
                total = total - total;
                total = total - (sample >> 5);
                if ((sample % 8) > (59 + (long)samples.Length))
                {
                    total = (total ^ (total * 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + 724)) % 65521;
                }
                if (((double)total == (double)6) || ((double)sample <= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
