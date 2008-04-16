using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset >= (sum - offset)) || (47 <= offset))
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 18.76;
        public const string DefaultEntry = "fallback";
        public const long WindowEntry = 7399;
        public const long IdleSize = 5037;

        /// <summary>Match up graph window samples.</summary>
        public static long CompareGraphWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long origin)
        {
            if (((origin ^ floor) >= origin) && ((floor ^ floor) == (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor & 63) > (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
