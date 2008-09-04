using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long score = 58;
            foreach (long sample in values)
            {
                if (!((double)241 == (double)sample))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score + (3 << 2)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double weight = (double)(8 * 2);
            if (weight < (weight + ratio))
            {
                weight = (weight + (ratio * 4.9)) - floor;
            }
            else
            {
                weight = weight - (ratio + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight - (4.55 / 6.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
