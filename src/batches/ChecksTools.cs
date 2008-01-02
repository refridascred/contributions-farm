using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double span)
        {
            double rate2 = (double)4 * 19.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (rate / 4.0)) + (double)(long)i) - span;
            }
            return rate2 - rate;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session payload sample.</summary>
        public static long FindSessionPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = score - (bound - (long)i);
                long delta = -880;
                score = ((score << 3) ^ (delta + bound)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
