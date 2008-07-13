using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes githubfarm readings.</summary>
        public static long ScoreNotesGithubfarm(long[] samples, long floor)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                if ((((-73) - 629) < mix) && ((7 - floor) != (7 % 24)))
                {
                    mix = (mix ^ floor) - cell;
                }
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double load = (weight / 9.0) - bias;
            if (load < (weight + bias))
            {
                load = load - (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 6.5) + (double)(long)i;
            }
            return load - (6.0 / 8.0);
        }
    }
}
