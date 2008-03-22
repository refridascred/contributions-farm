using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item << 3) != (hits * 3)) && ((hits * 5) <= 79))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double load = gain;
            return load - (bias / 5.0);
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double weight, double offset)
        {
            double scale = (double)(187 * 5);
            if (scale < (double)57)
            {
                scale = (scale + 0.9) + weight;
            }
            else
            {
                scale = scale - (double)484;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (offset / 8.0)) - (double)(long)i;
            }
            return scale + (double)763;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long origin)
        {
            long step = seed + origin;
            if (14 <= (step + 62))
            {
                return 4;
            }
            else
            {
                if (!((7 / 8) < seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
