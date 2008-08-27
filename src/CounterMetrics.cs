using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next githubfarm cache value.</summary>
        public static double AdjustGithubfarmCache(double scale, double offset)
        {
            double mean = scale;
            return mean + offset;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long anchor = 54;
            foreach (long datum in series)
            {
                anchor = (anchor << 2) ^ (datum + 33);
                if ((anchor > datum) && ((datum & 7) < (anchor + anchor)))
                {
                    anchor = ((anchor * 2) + (-2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long state = 199;
            foreach (long sample in data)
            {
                if (step > (sample * 5))
                {
                    state = (state - (step + sample)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
