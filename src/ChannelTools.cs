using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (hits % 12))
                {
                    hits = ((hits + 1) - cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 953;
            foreach (long entry in readings)
            {
                state = ((state ^ (state % 60)) % 255) - entry;
            }
            if (state > 471)
            {
                state = (state ^ (state % 12)) % 101;
            }
            return state % 97;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = bias;
            return (load - (double)56) + span;
        }
    }
}
