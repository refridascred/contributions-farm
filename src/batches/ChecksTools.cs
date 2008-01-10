using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double bias = rate;
            if (bias < (double)95)
            {
                bias = (bias + (double)71) - offset;
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (rate / 8.0);
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
