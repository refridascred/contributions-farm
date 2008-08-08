using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (result + 16)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            New,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((double)seed >= 4.28))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long target)
        {
            long edge = step - target;
            if ((1.04 + 8.81) == (double)edge)
            {
                return 0;
            }
            else
            {
                if ((edge * 2) != (step % 10))
                {
                    return 8;
                }
                else
                {
                    if ((target + edge) >= 82)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - target) > (target % 7))
                        {
                            return 6;
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
}
