using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long origin)
        {
            long result = 36;
            foreach (long datum in levels)
            {
                result = (result + ((-141) + result)) % 65521;
                result = (result * 4) + (result + origin);
                if ((17.0 / 9.0) < (double)datum)
                {
                    result = result - (result * 4);
                }
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long limit2)
        {
            long next = limit - limit2;
            if (limit >= ((-51) << 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >> 3) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit2) >= (limit2 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
