using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double ratio2 = (double)(6 - 70);
            if (ratio2 > (8.9 / 3.0))
            {
                ratio2 = (ratio2 - 4.0) + offset;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (double)172) + (double)(long)i;
            }
            return ratio2 + (ratio / 6.0);
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (load * 1.85)) + (double)(long)i) - gain;
            }
            return load + (double)(-67);
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
