using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next buffer githubfarm value from a seed.</summary>
        public static long StepBufferGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ (597 >> 2)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two schema batches measurements.</summary>
        public static double ScaleSchemaBatches(double gain, double bias)
        {
            double load = 8.0;
            if (load >= (double)36)
            {
                load = load + gain;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 7.0)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane <= 3) && ((lane + offset) >= (lane + 99)))
            {
                return 2;
            }
            else
            {
                if ((8 - lane) == (step * 4))
                {
                    return 5;
                }
                else
                {
                    if ((step % 3) <= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-9) >= (offset - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
