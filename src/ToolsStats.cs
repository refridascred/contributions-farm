using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry report figure with a bias.</summary>
        public static double ProjectEntryReport(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (double)0) + (double)(long)i) + bias;
            }
            return weight - (double)821;
        }
    }
}
