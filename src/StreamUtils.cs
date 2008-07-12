using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                sum = (sum ^ (922 + sample)) % 97;
                if ((double)sum == (1.2 * 4.33))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 2) < ((long)i >> 4))
                {
                    state = state + state;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long step)
        {
            long score = -11;
            foreach (long cell in data)
            {
                if ((cell / 4) < (score - cell))
                {
                    score = (score ^ (step + score)) % 1000;
                }
            }
            if (score < 80)
            {
                score = (score << 3) ^ (step + score);
            }
            return score % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long prev = floor - seed;
            if ((seed - floor) <= (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((prev + seed) != (61 ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (11.0 + 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor - seed) != (seed << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
