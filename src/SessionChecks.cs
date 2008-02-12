using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double scale = gain;
            if (scale < (span / 2.0))
            {
                scale = scale + (9.0 * 0.7);
            }
            return scale + (double)70;
        }

        /// <summary>Match up already filter samples.</summary>
        public static long MatchAlreadyFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((next + 33) < (seed & 31)) && ((bound & 7) <= 9))
            {
                return 2;
            }
            else
            {
                if (next <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound + 996) >= (bound ^ next))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.0 + 9.6) <= (double)next)
                        {
                            return 4;
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
}
