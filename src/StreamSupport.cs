using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double mean = (double)(50 & 3);
            if (mean > (floor * 20.0))
            {
                mean = mean - 7.7;
            }
            return mean - scale;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = score + (score + step);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            New,
            Pending,
            Draft,
        }
    }
}
