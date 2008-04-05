using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double gain = (9.0 + bias) + bias2;
            return gain + bias;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long step)
        {
            long gap = bound - step;
            if (!(gap > (step * 3)))
            {
                return 8;
            }
            else
            {
                if ((((-5) % 60) > (75 ^ bound)) && ((gap - gap) != (gap + bound)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double rate, double span)
        {
            double load = span / 3.0;
            if (load >= rate)
            {
                load = load - 8.4;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (span - load);
        }
    }
}
