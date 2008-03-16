using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double load = bias;
            if (load >= 16.0)
            {
                load = load - load;
            }
            return load + (scale + bias);
        }

        /// <summary>Classify a githubfarm checks pair into a bucket.</summary>
        public static long SortGithubfarmChecks(long target, long step)
        {
            if (step >= (step - target))
            {
                return 2;
            }
            else
            {
                if ((3.11 + 3.32) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if (((step ^ target) > step) && ((step % 8) > (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 5) != (step & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
