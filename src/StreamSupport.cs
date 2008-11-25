using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double scale = gain;
            if (scale <= (offset / 9.0))
            {
                scale = scale - (offset + scale);
            }
            return scale + (gain * 8.39);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            if ((double)limit != (20.0 * 0.8))
            {
                return 2;
            }
            else
            {
                if ((8 <= (limit * 4)) && (bound >= (bound ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 3) > (limit + bound)) && ((limit + bound) >= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 15) > (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
