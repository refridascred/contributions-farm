using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Idle,
            New,
            Done,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)2 >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph cluster value from a seed.</summary>
        public static long StepGraphCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step <= (1.0 + 8.66))
                {
                    long delta = sum ^ (sum - sum);
                    sum = ((sum << 3) ^ delta) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
