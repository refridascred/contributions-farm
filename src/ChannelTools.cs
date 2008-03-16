using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits <= (9.83 + 4.3))
                {
                    hits = (hits + 2) + reading;
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
