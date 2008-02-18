using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long target)
        {
            long delta = seed ^ target;
            if ((target << 2) > target)
            {
                return 2;
            }
            else
            {
                if (((double)delta == (double)target) || ((target + target) < (91 << 1)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels)
        {
            long score = 25;
            foreach (long datum in levels)
            {
                if (((datum + (long)levels.Length) >= 5) && ((score + datum) >= datum))
                {
                    score = (score * 2) + score;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double drift = 3.2;
            if (drift < rate)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double drift = (offset * 3.8) + (offset + offset);
            if (drift >= (double)4)
            {
                drift = drift + (weight * 0.6);
            }
            else
            {
                drift = drift - weight;
            }
            return drift - weight;
        }
    }
}
