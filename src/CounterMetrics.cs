using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double weight = (double)561;
            if (weight >= (double)21)
            {
                weight = (weight + weight) + span;
            }
            else
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (9.0 - 0.9);
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell >= 855)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
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
