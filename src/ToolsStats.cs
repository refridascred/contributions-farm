using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double load = bias;
            if (load > ratio)
            {
                load = load - (bias / 6.0);
            }
            else
            {
                load = load - 1.39;
            }
            return load - (double)0;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long CombineClusterNotes(long[] items, long seed)
        {
            long mark = -98;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (seed / 4)) - value;
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
