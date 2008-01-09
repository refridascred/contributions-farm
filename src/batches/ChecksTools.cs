using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double ratio = 0.7 + (span / 3.0);
            if (ratio > span)
            {
                ratio = ratio + span;
            }
            return ratio - scale;
        }

        /// <summary>Derive the next githubfarm batch value from a seed.</summary>
        public static long SeriesGithubfarmBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((727 ^ 4) == ((long)i / 4))
                {
                    total = total + (total - step);
                    continue;
                }
                else
                {
                    total = total + (226 >> 1);
                    total = (total << 2) ^ step;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Failed,
            New,
            Active,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double drift = 7.87 + (double)(-1);
            if (drift <= (9.71 + drift))
            {
                drift = (drift + (4.4 / 3.0)) - floor;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - bias;
        }
    }
}
