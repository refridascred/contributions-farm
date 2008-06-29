using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 5) + (sum + target);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a schema commits value against two limits.</summary>
        public static long ClassifySchemaCommits(long seed, long step)
        {
            long prev = seed ^ step;
            if ((930 % 60) != (step << 2))
            {
                return 3;
            }
            else
            {
                if ((double)seed != (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (((seed >> 3) > seed) && ((step & 127) >= prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
