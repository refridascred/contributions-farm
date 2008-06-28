using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (945 + entry)) ^ (long)i;
                }
                if (!(entry < (407 + 2)))
                {
                    continue;
                }
                if ((entry << 3) > (entry & 255))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long offset)
        {
            if ((double)offset < (5.9 / 8.0))
            {
                return 6;
            }
            else
            {
                if (offset <= (bound & 1))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound <= (5.0 + 8.41)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + 92) >= (offset << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double load = rate * 7.0;
            if (load <= (rate / 7.0))
            {
                load = (load + (rate + load)) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (double)7;
        }
    }
}
