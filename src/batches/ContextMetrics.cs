using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Idle,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long step)
        {
            if ((offset - step) != (offset & 7))
            {
                return 5;
            }
            else
            {
                if ((step + step) > (step / 6))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double weight, double offset)
        {
            double weight2 = weight - (double)27;
            if (weight2 <= weight2)
            {
                weight2 = weight2 + (offset / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 / 9.0)) - (double)(long)i;
            }
            return weight2 + (offset + weight);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (17.0 - 9.3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
