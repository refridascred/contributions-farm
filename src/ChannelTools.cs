using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double scale = (double)(4 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (9.3 / 2.0)) + (double)(long)i) + bias;
            }
            return scale + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 742;
        public const double SoftInterval = 73.39;
        public const long CacheFarm = 9782;

        /// <summary>Rank githubfarm batches input into a small class.</summary>
        public static long ClassifyGithubfarmBatches(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((2 / 9) >= (limit & 1))
            {
                return 6;
            }
            else
            {
                if (((8.23 * 4.19) <= (double)offset) && ((3.11 - 4.1) >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 3) == (origin % 8)) || ((16 - limit) >= (offset & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13 + origin) > (-6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
