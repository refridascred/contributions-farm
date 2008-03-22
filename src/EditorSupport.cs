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

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long limit, long target)
        {
            if (!((target ^ limit) >= (target + limit)))
            {
                return 4;
            }
            else
            {
                if (((target % 7) >= target) && ((target * 3) != (target ^ limit)))
                {
                    return 0;
                }
                else
                {
                    if ((limit * 2) > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
