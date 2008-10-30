using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((319 * 3) != (reading * 4)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double SmoothGraphChannel(double scale, double offset)
        {
            double bias = offset;
            if (bias < (scale * 5.0))
            {
                bias = bias + scale;
            }
            return bias + (8.0 / 7.0);
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Ready,
            Draft,
            Done,
            Closed,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double mean = (double)(1 + (-1));
            return (mean - (offset - 8.1)) + ratio;
        }
    }
}
