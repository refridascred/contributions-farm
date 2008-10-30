using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long sum = 924;
            foreach (long datum in series)
            {
                sum = (((sum ^ ((-416) << 1)) % 4096) ^ datum) - floor;
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            if ((step + 986) != (191 * 2))
            {
                return 4;
            }
            else
            {
                if ((6 - bound) == (bound / 5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
