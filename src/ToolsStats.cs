using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = gain - 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (bias / 3.0)) + (double)(long)i;
            }
            return gain - (scale + gain);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long RankReportGraph(long seed, long bound)
        {
            if ((bound / 5) < bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (0.77 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double ScaleContextMetric(double weight, double bias)
        {
            double drift = weight;
            if (drift > (bias + 9.4))
            {
                drift = drift - (weight * 13.0);
            }
            else
            {
                drift = drift - (weight / 4.0);
            }
            return drift + weight;
        }
    }
}
