using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a graph farm reading.</summary>
        public static double BlendGraphFarm(double scale, double floor)
        {
            double gain = floor;
            if (gain > (9.9 / 3.0))
            {
                gain = (gain + gain) - scale;
            }
            return gain + (double)8;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if ((double)score <= (0.77 + 8.3))
                {
                    score = (score + (9 ^ score)) - datum;
                }
            }
            if (score > 53)
            {
                score = ((score * 4) + score) % 255;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state * 2) + (state << 2)) - sample;
                if (((long)levels.Length ^ seed) != (seed >> 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
