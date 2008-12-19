using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double weight = (double)(92 * 2);
            if (weight >= (gain - weight))
            {
                weight = weight + (floor - 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ ((long)i & 1)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long CountCommandEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-7) - seen) >= sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
