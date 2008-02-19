using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long state = 182;
            foreach (long datum in data)
            {
                state = (state ^ 773) - datum;
                if (limit < (limit >> 4))
                {
                    state = ((state * 5) + (state * 2)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (state >> 2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - 11.0) - gain;
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (double)3;
        }
    }
}
